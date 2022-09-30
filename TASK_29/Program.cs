// Программа задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next();
    }
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1)
        Console.Write($", ");
    }
    Console.Write("]");
}




