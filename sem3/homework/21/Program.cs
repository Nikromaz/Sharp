// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
double distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    //result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    //result = Math.Round(result, 2);
    return result;
}
Console.Clear();
Console.WriteLine("Узнайте расстояние между двумя точками в пространстве. ");
Console.Write("Введите координату x точки A: ");
int ax = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y точки A: ");
int ay = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z точки A: ");
int az = int.Parse(Console.ReadLine()!);
Console.WriteLine("!!!");
Console.Write("Введите координату x точки B: ");
int bx = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату x точки B: ");
int by = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату x точки B: ");
int bz = int.Parse(Console.ReadLine()!);
Console.Write($"Длина отрезка AB: {distance(ax, ay, az, bx, by, bz):f2}");