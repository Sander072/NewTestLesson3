n = int(input())
m = int(input())
k = int(input())

if n * m > k:
    if (k % n == 0) or (k % m == 0):
        print('yes')
    else:
        print('no')
else:
    print('no')