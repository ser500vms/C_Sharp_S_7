// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

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
int[,] array = Generate2DArray(m, n, -99, 99); 
Print2DArray(array);