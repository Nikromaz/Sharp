//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Надо задать две функции:
// 1я функция принимает строку от пользователя (см. задачу 33 на последнем семинаре)
// 2я функция выводит массив на печать (см. задача 32 там же)
int[] GetArrayFromString(string UsersNumbers) //Функция создания массива из строки
{
    string[] numbers = UsersNumbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[numbers.Length];
      for (int i = 0; i < numbers.Length; i++)
    {
        res[i] = int.Parse(numbers[i]);
    }
    return res;
}
void PrintArray(int[] mass) //Функция вывода массива
{
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i]);
        if (i != mass.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
Console.Clear();
Console.WriteLine("Введите числа массива через пробел: ");
string input = Console.ReadLine()!;
int[] numbersArray = GetArrayFromString(input);
PrintArray(numbersArray);