// Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 , y = k2 * x + b2. Значения k1, k2, b1, b2 задаются пользователем.

Console.Clear();

Console.Write("Введите коэффициент k1: ");
double k1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите коэффициент b1: ");
double b1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите коэффициент k2: ");
double k2 = double.Parse(Console.ReadLine()!);

Console.Write("Введите коэффициент b2: ");
double b2 = double.Parse(Console.ReadLine()!);

Intersection(k1, b1, k2, b2);

void Intersection(double k1, double b1, double k2, double b2)
{
    if ((k1 == k2) && (b1 != b2))
    {
        Console.WriteLine("Эти прямые параллельны");
    }
    else if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Эти прямые совпадают");
    }
    else
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых имеет координаты ({x},{y})");
    }
}