n = int(input('Сколько чисел в массиве: '))
L = []
L = [int(input('Число массива: ')) for i in range(n) ]
z = int(input('К какому числу ищем самое близкое: '))
x = 0
for y in range(n):
    if (abs(z - L[y])) < (abs(z - L[x])):
        x = y
print('Самое близкое значение:', L[x])