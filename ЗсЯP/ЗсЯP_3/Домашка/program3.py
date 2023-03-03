
L1 = ['A', 'E', 'I', 'O', 'U', 'L', 'N', 'S', 'T', 'R', 'А', 'В', 'Е', 'И', 'Н', 'О', 'Р', 'С', 'Т']
L2 = ['D', 'G', 'Д', 'К', 'Л', 'М', 'П', 'У']
L3 = ['B', 'C', 'M', 'P', 'Б', 'Г', 'Ё', 'Ь', 'Я']
L4 = ['F', 'H', 'V', 'W', 'Y', 'Й', 'Ы']
L5 = ['K', 'Ж', 'З', 'Х', 'Ц', 'Ч']
L8 = ['J', 'X', 'Ш', 'Э', 'Ю']
L10 = ['Q', 'Z', 'Ф', 'Щ', 'Ъ']
n = input('Введите слово (Заглавными): ')
z = 0
for y in range(len(n)):
    for n1 in range(len(L1)):
        if n[y] == L1[n1]:
            z += 1
    for n2 in range(len(L2)):
        if n[y] == L2[n2]:
            z += 2
    for n3 in range(len(L3)):
        if n[y] == L3[n3]:
            z += 3
    for n4 in range(len(L4)):
        if n[y] == L4[n4]:
            z += 4
    for n5 in range(len(L5)):
        if n[y] == L5[n5]:
            z += 5
    for n8 in range(len(L8)):
        if n[y] == L8[n8]:
            z += 8
    for n10 in range(len(L10)):
        if n[y] == L10[n10]:
            z += 10
print('Набранное количество очков:', z)