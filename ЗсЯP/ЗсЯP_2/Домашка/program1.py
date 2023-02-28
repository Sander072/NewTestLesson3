n = int(input('Сколько монет на столе? '))
count_zero = 0
count_one = 0
for i in range(n):
    x = int(input('Какой стороной лежит монетка? 0 или 1? '))
    if x == 0:
        count_zero += 1
    else:
        count_one += 1
if count_one > count_zero:
    print('Нужно сделать', count_zero ,'поверотов монеток')
else:
    print('Нужно сделать ', count_one ,'поверотов монеток')