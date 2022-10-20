// Программа находит сумму натуральных элементов в промежутке от M до N рекурсивно.

Console.Clear();

Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);

int summa = RecSumma(firstNumber, secondNumber);
Console.WriteLine(summa);



int RecSumma(int a, int b, int summa = 0)
{
    if (a > b)
        return summa;    
    else
    {
        return RecSumma(a + 1, b, summa + a);
    }
}