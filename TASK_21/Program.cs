// Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Введите координаты точки А: ");
Console.Write("x= ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("y= ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("z= ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B: ");
Console.Write("x= ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("y= ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("z= ");
int z2 = int.Parse(Console.ReadLine()!);

int dx = x2 - x1;
int dy = y2 - y1;
int dz = z2 - z1;

double dist = Math.Pow(dx * dx + dy * dy + dz * dz, 0.5);

Console.WriteLine($"Расстояние между точками = {dist:f2}");


