import Input
import Output
import Edit

while True:
    choise = int(input('Введите нужное действие: \
        \n 1 - Добавить в справочник \
        \n 2 - Вывести всех \
        \n 3 - Поиск по фамилии \
        \n 4 - Редактировать контакт \
        \n 5 - Удалить контакт \
        \n 6 - Выход \n'))
    match choise: 
        case 1: 
            Input.Input(input('Введите фамилию: '), input('Введите номер: '))
        case 2: 
            Output.OutputAll()
        case 3:
            Output.Search(input('Введите фамилию: '))
        case 4:
            Edit.Edit(input('Введите фамилию или номер контакта, которые хотите изменить: '))
        case 5:
            Edit.Delete(input('Введите фамилию или номер контакта, которые хотите удалить: '))
        case 6: break
