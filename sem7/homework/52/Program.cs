// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void GetAverageOfColumns(int[,] massive)
{
    int[] summ = new int[massive.GetLength(0)];
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {            
            summ[i] += massive[j, i];
        }
    }
    foreach (double elem in summ)
    {
        Console.WriteLine(elem / massive.GetLength(1));
    }
}

Console.Clear();
int row = new Random().Next(3, 6);
int columns = new Random().Next(3, 6);
int[,] array = GetArray(row, columns, 0, 10);

PrintArray(array);
GetAverageOfColumns(array);