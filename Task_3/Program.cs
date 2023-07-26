// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив
//  выглядел вот так: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] NewIndexArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] *= matrix[i, j];
            j++;
        }
    }
    return matrix;
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
int[,] array2 = NewIndexArray(array);
Print2DArray(array2);