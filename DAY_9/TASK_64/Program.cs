Console.Clear();

Console.Write("Введите целое положительное число: ");
int number = int.Parse(Console.ReadLine()!);

NaturalNumbersSequence(number);



void NaturalNumbersSequence(int num)
{
    if (num == 1)
        Console.Write($"{num}");    
    else
    {
        Console.Write($"{num}, ");
        NaturalNumbersSequence(num-1);
    }
}
