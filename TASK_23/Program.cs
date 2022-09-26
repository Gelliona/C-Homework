// Программа принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N

Console.Clear();

Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine()!);

for (int count = 1; count <= num; count++)
{
    Console.Write($"{count*count*count}");
    if (count!=num)
        Console.Write($", ");
}


