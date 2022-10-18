// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Брал за основу Задача 31.
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int[] GetArray(int size, int minValue, int maxValue) //Функция создания массива
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int PrintArray(int[] mass) //Функция вывода массива
{

}
Console.Clear();
int[] array = GetArray(4, 111, 999);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(PrintArray);
