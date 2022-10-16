// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
int CountNumber(int a)
{
    int count = 0;
    if (a == 0)
    {
        return 1;
    }
    while (a != 0)
    {
        count++;
        a = a / 10;
    }
    return count;
}
Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine()!);
int result = CountNumber(A);
Console.WriteLine(result);