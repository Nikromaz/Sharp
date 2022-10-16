//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int GetPow(int n, int d)
{
    int pow = 1;
    for (int i = 0; i < d; i++)
    {
        pow = pow *n;
    }
    return pow;
}
Console.Clear();
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень в которую необходимо возвести: ");
int Degree = int.Parse(Console.ReadLine()!);
int Result = GetPow(Number, Degree);
Console.WriteLine($"Число {Number} в степени {Degree} равно: {Result}");
// int GetPow(int x, int n)
// {
//     int Pow = 1;
//     if (n == 1)
//         return x;
//     else
//     {
//         Pow = (x * GetPow(x, n - 1));
//     }
//     return Pow;
// }