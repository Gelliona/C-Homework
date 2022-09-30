// Программа принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int summa = 0;

int SummaOfDigits(int num)
{
    while (num != 0)
    {
        int lastDigit = num % 10;
        summa = summa + lastDigit;
        num = num / 10;
    }
    if (summa < 0)
        summa = summa * (-1);
    return summa;
}

int total = SummaOfDigits(number);
Console.WriteLine($"Сумма цифр в этом числе = {total}");

