x = int(input('Сколько всего журавликов: '))
if x % 6 == 0:
    y1 = 0
    y2 = 0
    y3 = 0
    y2 = x / 3 * 2
    y1 = y2 / 4
    y3 = y1
    print (int(y1), int(y2), int(y3))
else:
    print ('Число не подходит для этой задачи')
