Console.Clear();

Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int number3 = int.Parse(Console.ReadLine());

int maximum = number1;

if (number2 > maximum)
{
    maximum = number2;
}
if (number3 > maximum)
{
    maximum = number3;
}

Console.WriteLine(maximum);
