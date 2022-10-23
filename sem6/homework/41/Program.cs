// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] GetArrayFromString(string stringArray)//Функция создания массива из строки ввода
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int PositiveNumberCount(int[] massive)//Функция подсчета положительных чисел в массиве
{
    int count = 0;
    foreach (int number in massive)
    {
        if(number > 0)
        {
            count++;
        }
    }
    return count;
}
Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
string input = Console.ReadLine()!;
int[] numArray = GetArrayFromString(input); //Ввод переменной массива с присвоением значения
// из функции создания массива из строки ввода
int count = PositiveNumberCount(numArray); // Ввод переменной счетчика с присвоением значения
// функции подсчета положительных чисел 
Console.WriteLine($"Количество чисел больше нуля в массиве: {count}");