// Программа принимает число A. После этого пользователь вводит А чисел. Программа выводит, сколько из них было положительных.

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int pozitiveCount = PositiveNumbers(num);
Console.WriteLine(pozitiveCount);

/*
int PositiveNumbers(int number)                                 // Вариант с классическим циклом
{
    int counter = 0;
    for (int i = 0; i < number; i++)
    {
        Console.Write("Введите число: ");
        int newNumber = int.Parse(Console.ReadLine()!);
        if (newNumber > 0)
            counter++;
    }
    return counter;
}
*/

int PositiveNumbers(int number, int i = 1, int counter = 0)     // Вариант с рекурсией
{
    if (i > number) 
        return counter;
    else
    {
        int newNumber = int.Parse(Console.ReadLine()!);
        if (newNumber > 0)
        {
            return PositiveNumbers(number, ++i, ++counter);
        }
        else
        {
            return PositiveNumbers(number, ++i, counter);
        }    
    }
}


