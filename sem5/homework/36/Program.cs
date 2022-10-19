// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArray(int size, int minValue, int maxValue) //Функция создания массива (из задачи 31)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int SumOddNumbers(int[] array)//функция суммирования чисел нечетных индексов массива
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Для того, чтобы создать массив,");
Console.WriteLine("введите количество элементов в массиве: ");
int N = int.Parse(Console.ReadLine()!);
int[] array = GetArray(N, -10, 10);
Console.WriteLine($"Сгенерированный массив из {N} элементов: [{(String.Join(", ", array))}]");
Console.WriteLine($"Сумма чисел нечетных индексов в данном масcиве равна: {SumOddNumbers(array)}");