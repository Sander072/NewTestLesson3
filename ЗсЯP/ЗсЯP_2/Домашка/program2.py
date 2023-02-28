s = int(input('Сумма: '))
p = int(input('Произведение: '))
for x in range(s):
    for y in range(p):
        if s == x + y and p == x * y:
            print('Загаданные числа:', x, y)