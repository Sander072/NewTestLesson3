n = int(input('Сколько чисел в массиве: '))
L = []
L = [int(input('Число массива: ')) for i in range(n) ]
z = int(input('Наличие какого числа проверяем: '))
x = 0
for y in range(n):
    if L[y] == z:
        x += 1
print('Колличество повторов:', x)