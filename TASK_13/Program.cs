Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number >= 100)
{
    while (number >= 999)
        number = number / 10;
    number = number % 10;
    Console.WriteLine(number);
}
else
    Console.WriteLine("В числе нет третьей цифры");

