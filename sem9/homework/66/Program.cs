// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromMtoN(int m, int n)
{
    if (m == n) return n;
    if (m > n) return m + SumFromMtoN(m - 1, n);
    else return m + SumFromMtoN(m + 1, n);
}

Console.Clear();
Console.Write("Введите значение переменной M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение переменной N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Clear();
Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} равна: {SumFromMtoN(m, n)}");