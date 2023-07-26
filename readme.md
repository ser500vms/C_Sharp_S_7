Task_1:
Задача 46: Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1

Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = i+j. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5

Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12


// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

<!-- void PositiveNumber(List<int> array)
{  
    int count = 0;
    for (int i = 0; i < array.Count; i++)
    {
        if (array[i] > 0) count++;          
    }
    Console.WriteLine($"Количество чисел > 0 в массиве - {count} !!");
}

List<int> GetDynamicArray()
{
    List<int> dArray = new List<int>();
    int number;
    bool isValidNumber = false;
    Console.WriteLine("Введите целые числа (любой другой символ окончание ввода):");    
    do
    {
        Console.Write("Следующее число: ");
        string input = Console.ReadLine();
        isValidNumber = int.TryParse(input, out number);               
        if (isValidNumber) dArray.Add(number);             
    }
    while(isValidNumber);
    Console.WriteLine($"Сгенерирован массив - [{String.Join(", ", dArray)}]");
    return dArray;
}

PositiveNumber(GetDynamicArray()); -->