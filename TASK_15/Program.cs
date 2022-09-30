Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


if ((number >= 1) && (number <= 7))
{
    if ((number == 6) || (number == 7))
        Console.WriteLine("Это выходной день");
    else
        Console.WriteLine("Это рабочий день");
}
else
    Console.WriteLine("Ошибка ввода! Введите число от 1 до 7");
