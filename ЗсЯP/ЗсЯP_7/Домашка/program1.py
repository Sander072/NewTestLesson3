n = input('Введите предложение: ')
st = n.lower().split()
f = lambda x: sum(1 for i in x if i in 'аеёиоуыэюя')
tmp = f(st[0])
if all([f(i) == tmp for i in st]):
    print('Парам пам-пам')
else:
    print('Пам парам')