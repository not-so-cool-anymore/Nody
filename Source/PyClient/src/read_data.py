import serial
import sys, os
sys.path.append("/home/Nody/Source/PyClient/src")
import src.check_port as checker
import time as t


def read():
    received_data = []

    while 1:
        connection_status = checker.check_availability()

        if connection_status == 1:

            try:
                serial_conn = serial.Serial("/dev/ttyUSB0", 9600)

                for i in range(2):
                    if serial_conn.isOpen():
                        received_temp = serial_conn.readline().rstrip().decode("ascii")
                        received_data.append(received_temp)
                return received_data
                break

            except Exception as exc:
                del received_data[:]
                print("Error: Device might be disconnected")
                print(exc)
                t.sleep(2)
                os.execl(sys.executable, sys.executable, *sys.argv)
