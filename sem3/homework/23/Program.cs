// Задача 23
// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
void ListOfCube(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i*i*i}");
        if (i != n)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write(".");
        }
    }
}
Console.Clear();
Console.WriteLine("Таблица кубов введенного числа.");
Console.Write("Введите ваше число: ");
int N = int.Parse(Console.ReadLine()!);
ListOfCube(N);