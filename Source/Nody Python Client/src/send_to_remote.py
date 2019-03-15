import time


def send_to_remote(sock, data):

    data_bytes = bytearray(data, "ascii")

    bytes_length = len(data_bytes)  # length of the array that I am sending

    print(bytes_length)
    print(type(data_bytes))

    sock.sendall(data_bytes)  # sending the data
    time.sleep(0.2)

