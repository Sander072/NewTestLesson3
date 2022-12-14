# Туториал по Git
Это будет наш маленький справочник по системе контроля версий.

## Инициализация репозитория

Чтобы инициализировать репозиторий (создать место для изменения версий файлов), используйте следующую команду:

```
git init
```
## Добавление файлов в репозиторий

Чтобы добавить файл в репозиторий, необходимо прописать следующую команду:
```
git add <название файла>
```
 
## Создание коммита

Чтобы создать коммит, необходимо прописать следующую команду:
```
git commit -m “message” 
```

## Получение информации от git о его текущем состоянии

Чтобы получить информацию от git о его текущем состоянии, необходимо прописать следующую команду:
```
git status
```
## Вывод на экран истории всех коммитов с их хеш-кодами

Чтобы вывести на экран истории всех коммитов с их хеш-кодами, необходимо прописать следующую команду:
```
git log
```

## Переход от одного коммита к другому

Чтобы перейти от одного коммита к другому, необходимо прописать следующую команду:
```
git checkout
```

## Возвращение к актуальному состоянию и продолжение работы

Чтобы вернуться к актуальному состоянию и продолжить работу, необходимо прописать следующую команду:
```
git checkout master
```

## Возможность увидеть разницу между текущим файлом и закоммиченным файлом

Чтобы увидеть разницу между текущим файлом и закоммиченным файлом, необходимо прописать следующую команду:
```
git diff
```

## Изменение последнего коммита

Чтобы измененить последний коммит, необходимо прописать следующую команду:
```
git commit --amend -m “message” 
```

## Создание новой директории

Чтобы создать новую директорию, необходимо прописать следующую команду:
```
mkdir названиепапки
```

## Все введённые когда-либо в терминал команды

Чтобы увидеть все введённые когда-либо в терминал команды, необходимо прописать следующую команду:
```
history
```