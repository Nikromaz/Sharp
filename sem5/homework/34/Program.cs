// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue) //Функция создания массива (взял из задачи 31)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int IsEven(int[] array)//функция проверки элементов массива на четность
{
    int EvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            EvenNumbers++;
        }
    }
    return EvenNumbers;
}
Console.Clear();
Console.WriteLine("Для того, чтобы создать массив,");
Console.WriteLine("введите количество элементов в массиве: ");
int N = int.Parse(Console.ReadLine()!);
int[] array = GetArray(N, 100, 999);
Console.Write($"Сгенерированный массив, трехзначных чисел из {N} элементов: [");
Console.Write(String.Join(", ", array));
Console.Write("]");
Console.WriteLine();
Console.WriteLine($"В данном массиве {IsEven(array)} четных числа.");