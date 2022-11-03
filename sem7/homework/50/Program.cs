// Задача 50. Напишите программу, которая на вход принимает число и возвращает индексы элемента
// в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)//функция создания двумерного массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    return result;
}

void PrintArray(int[,] inArray)//функция вывода массива на печать
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

void FindingNumberMatch(int[,] massive, int number)//функция поиска числа в массиве
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (massive[i, j] == number)
            {
                Console.WriteLine($"Индекс найденного элемента:[{i};{j}]");
                return;
            }
        }
    }
    Console.WriteLine("Такого числа в массиве нет");
}

Console.Clear();
int row = new Random().Next(3, 6);
int columns = new Random().Next(3, 6);
int[,] array = GetArray(row, columns, 0, 10);

Console.WriteLine("Поиск числа в массиве");
Console.WriteLine("Введите число: ");
int inputNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine();
PrintArray(array);
FindingNumberMatch(array, inputNumber);
