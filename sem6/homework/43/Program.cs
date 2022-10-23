// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void GetIntersectionCoordinates(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Уравнения прямых идентичны. Прямые совпадают!");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
    }
}
Console.Clear();
Console.WriteLine("Программа поиска координат пересечения прямых уравнения типа: y=kx+b");
Console.WriteLine("Ввод координат ПЕРВОЙ прямой");
Console.WriteLine("Введите значение координаты k: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение координаты b: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод координат ВТОРОЙ прямой");
Console.WriteLine("Введите значение координаты k: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение координаты b: ");
double b2 = double.Parse(Console.ReadLine()!);
GetIntersectionCoordinates(k1, b1, k2, b2);