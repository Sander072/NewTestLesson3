# Туториал по языку разметки MarkDown

## Как добавить зачёркивание
**Чтобы добавить зачёркивание в разметку MarkDown, используйте следующую конструкцию:**

```
две тильды `~` до и после текста
```

Пример:

~~Хе-хе~~

## Как добавить цитаты
Чтобы добавить цитату, необходимо использовать конструкцию следующего вида:
```
Цитаты оформляются как в емейлах, с помощью символа `>`.
```
Пример:

> This is a blockquote with two paragraphs. Lorem ipsum dolor sit amet,
> consectetuer adipiscing elit. Aliquam hendrerit mi posuere lectus.
> Vestibulum enim wisi, viverra nec, fringilla in, laoreet vitae, risus.
>
> Donec sit amet nisl. Aliquam semper ipsum sit amet velit. Suspendisse
> id sem consectetuer libero luctus adipiscing.

Или более ленивым способом:
```
Знак `>` ставится перед каждым элементом цитаты, будь то абзац, заголовок или пустая строка
```
Пример:

> This is a blockquote with two paragraphs. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aliquam hendrerit mi posuere lectus. Vestibulum enim wisi, viverra nec, fringilla in, laoreet vitae, risus.
>
> Donec sit amet nisl. Aliquam semper ipsum sit amet velit. Suspendisse id sem consectetuer libero luctus adipiscing.

```
В цитаты можно помещать всё что угодно, в том числе вложенные цитаты:
```
> ## This is a header.
>
> 1. This is the first list item.
> 2. This is the second list item.
>This is a header.
>
>>Вложенная цитата.
>
>Here's some example code:
>
>return shell_exec("echo $input | $markdown
_script");
>

## Как добавить картинки
Чтобы добавить изображения в разметку MarkDown, используйте следующую конструкцию:
```
![альтернативный текст](ссылка на изображение)
```
Пример:
![альтернативный текст](https://funart.pro/uploads/posts/2021-03/1617048969_52-p-oboi-krasivie-peizazhi-prirodi-56.jpg)

## Как добавить исходный код
Чтобы добавить исходный код, необходимо использовать конструкцию следующего вида:
```
html<table><tr><td style="color:#ff7834">Текст</td></tr></table>
```
Пример рабочего кода без кавычек:

<table><tr><td style="color:#FFD700">Текст</td></tr></table>
