// Цикл принимает на вход два числа (А и В) и возводит А в натуральную степень В
Console.Clear();

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);



int Power(int num1, int num2)
{
    int total = 1;
    while (num2 != 0)
    {
        total = total * num1;
        num2--;
    }
    return total;
}

int total = Power(a, b);

Console.WriteLine($"{a} ^ {b} = {total}");

