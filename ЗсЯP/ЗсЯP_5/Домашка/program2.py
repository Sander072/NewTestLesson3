a = int(input('Число 1: '))
b = int(input('Число 2: '))

def sum(a, b):
    if b == 0:
        print('Итоговое число:', a)
        return
    a += 1
    b -= 1
    sum(a, b)

sum(a, b)