// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Введите координаты X1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты X2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками {distance:f3}");


