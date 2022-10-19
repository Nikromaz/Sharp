// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] GetArray(int size, int minValue, int maxValue) //Функция создания массива
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return res;
}
double Diff(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    diff = max - min;
    return diff;
}


// double maxArrayElement(double[] array)
// {
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }
// double minArrayElement(double[] array)
// {
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     return min;
// }
Console.Clear();
Console.WriteLine("Для того, чтобы создать массив,");
Console.WriteLine("введите количество элементов в массиве: ");
int N = int.Parse(Console.ReadLine()!);
double[] array = GetArray(N, -100, 100);
Console.WriteLine($"Сгенерированный массив из {N} элементов: [{(String.Join(", ", array))}]");
// double max = maxArrayElement(array);
// double min = minArrayElement(array);
// Console.WriteLine($"Разность между максимальным ({max}) и минимальным ({min}) числом массива равна: {max - min}");
Console.WriteLine($"Разность между максимальным и минимальным числом массива равна: {Diff(array):f2}");