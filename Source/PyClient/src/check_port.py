import os


def check_availability():

    check = os.path.exists('/dev/ttyUSB0')

    if check == 1:
        return 1
        print("Device path exist")

    else:
        return 0
