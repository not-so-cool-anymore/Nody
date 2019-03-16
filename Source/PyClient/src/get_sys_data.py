def get_sys_data(data_type):
    data_array = []

    with open("sys_data.txt") as data_file:
       for line in data_file:
            data_array.append(line)

    for i in range(len(data_array)):
        if data_type in data_array[i]:
            return data_array[i].split("=", 1)[1]

