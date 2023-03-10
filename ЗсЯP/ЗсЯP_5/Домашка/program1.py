a = int(input('Число: '))
b = int(input('Степень: '))
c = a
d = 1

def degree(a, b, c, d):
    if b == 0:
        print('Итоговое число: 1')
        return
    if d == b:
        print('Итоговое число: ', c)
        return
    c = c * a
    d += 1
    degree(a, b, c, d)

degree(a, b, c, d)