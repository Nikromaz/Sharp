// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersFromNtoOne(int n)
{
    if (n < 1) return $"Введенное значение меньше единицы. Введите натуральное число";
    if (n == 1) return $"{1}";
    else return $"{n}, " + NumbersFromNtoOne(n - 1);
}

Console.Clear();
Console.Write("Введите значение переменной N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Clear();
Console.WriteLine($"Натуральные числа в промежутке от {n} до {1}: {NumbersFromNtoOne(n)}.");