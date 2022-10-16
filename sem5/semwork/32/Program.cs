// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void Reverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}
Console.Clear();
int[] array = GetArray(5, -10, 10);
Console.WriteLine(String.Join(", ", array));
Reverse(array);
Console.WriteLine(String.Join(", ", array));