**Задача:**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

**Описание алгоритма решения:**

Сначала запрашиваем у пользователя массив, и просим разделить элементы пробелом. Потом с помощью команды Split «нарезаем» введённую строку. Присваиваем результат, созданному массиву myArray.
Создаём новый массив, который будет содержать ответ, называем его resArray. Заполняем его с помощью функции ChooseLessThan3, которая обрабатывает массив, введённый пользователем (myArray).
Выводим на экран массив resArray  с помощью функции ShowArray
ChooseLessThan3: Создаём новый массив, у которого длинна такая же, как у обрабатываемого массива. Создаём переменную resultIndex, приравниваем её к 0. Затем внутри цикла той же длинны, что и массив, проверяем условие (<=3) в каждом элементе первого массива. Если условие выполняется, то записываем элемент из первого массива во второй и прибавляем к resultIndex +1. Если нет, просто  переходим к следующему элементу первого массива. Возвращаем получившийся массив.

ShowArray: Принимаем массив, который нужно вывести на экран. Через цикл for перебираем каждый элемент и печатаем.

Блоксхема:
![Здесь должна быть блоксхема](DiagramFW.png)