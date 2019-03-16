import socket
import time
import sys
import os
import traceback
sys.path.append("/home/Nody/Source/PyClient/src")
import src.read_data as read
import src.get_sys_data as gsd
import src.send_to_remote as r_send

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
    #node_socket.send(location_data.encode())
    #node_socket.send(name_data.encode())
    # Starts data reading and sending
    #while 1:
        # for i in range(received_data.count()):
            # client_socket.sendall(received_data[i])

except Exception as exc:
    print(traceback.format_exc())

