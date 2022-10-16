// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);
int n1 = N / 10000;
int n2 = N / 1000 % 10;
int n4 = N / 10 % 10;
int n5 = N % 10;
if (N > 99999 || N < 9999)
{
    Console.WriteLine("Вообще не то пальто!");
}
else if (n1 == n5 && n2 == n4)
{
    Console.WriteLine("Да, это ПАЛИНДРОМ!");
}
else
{
    Console.WriteLine("Неа, не палиндром!");
}
// var n = N.ToString();
// if (n.Reverse().SequenceEqual(n)) Console.WriteLine("Палиндром!");
// else Console.WriteLine("Не палиндром!");