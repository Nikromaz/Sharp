//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите число: ");
int Numbers = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {Numbers}: {SumDigits(Numbers)}");
