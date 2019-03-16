import socket
import os
import traceback
import read_data as read
import get_sys_data as gsd
import send_to_remote as r_send

ip_address = ("127.0.0.1", 1024)

node_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
node_socket.connect(ip_address)

try:

    # Sends data about the device to the server on connect (loops were not used intentionally)
    location_data = gsd.get_sys_data("location")
    name_data = gsd.get_sys_data("name")
    device_owner_data = gsd.get_sys_data("owner")

    r_send.send_to_remote(node_socket, location_data)

    r_send.send_to_remote(node_socket, name_data)

    r_send.send_to_remote(node_socket, device_owner_data)

    # Starts data reading and sending
    while 1:
        received_data = read.read()
        for i in range(len(received_data)):
            r_send.send_to_remote(node_socket, received_data[i])

except Exception as exc:
    print(traceback.format_exc())

