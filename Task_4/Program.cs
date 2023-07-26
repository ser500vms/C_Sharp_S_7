// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int FindSumDiag(int[,] matrix)
{
    Console.Write(matrix[0, 0]);
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0 + i; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            Console.Write($" + {matrix[i, j]}");
            break; 
        }
    }
    return sum;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t", -5);
        }
        Console.WriteLine();
    }
}

int[,] Generate2DArray(int rows, int collums, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, collums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput ("Введите колличествол строк массива: ");
int n = GetInput ("Введите колличествол столбцов массива: ");
int[,] array = Generate2DArray(m, n, 1, 3); 
Print2DArray(array);
Console.WriteLine();
int sum = FindSumDiag(array);
Console.Write($" = {sum}");