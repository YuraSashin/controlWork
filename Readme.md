**задача**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых маньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте через выполнение алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры: ["hello", "2", "world", ":-)" ] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science" ] -> ["-2"]

["Russia", "Denmark", "Kazan" ] -> []

*Решение*

1. Задал начальный массив(из примеров)
2. Определил длинну массива(прогнал начальный массив и определил кол-во элементов соответсвущех условию)
3. Создал новый массив используя длинну полученную с прошлой итерации, заполнив новый соответствущими элементами
4. Вывел исходный и результирующий массив