// Программа выводит первые N чисел Фибоначчи, не используя рекурсию

Console.Clear();

Console.Write("Введите число: "); 
int n = int.Parse(Console.ReadLine()!);

int[] array = new int[n];
FindFibonacci(array, n);
PrintFibonacci(array);


void FindFibonacci(int[] array, int number)
{
    for (int i = 0; i < number; i++)
    {
        if (i < 2)
            array[i] = i;
        else
            array[i] = array[i-1] + array[i-2];
    }
}

void PrintFibonacci(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1)
        Console.Write($", ");
    }
}