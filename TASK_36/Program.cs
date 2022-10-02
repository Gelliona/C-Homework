// Программа заполняет массив случайными числами и находит сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] array = CreateArray();
FillArray(array);
PrintArray(array);
int oddPositionSum = sumOfOddPosition(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях = {oddPositionSum}");


int[] CreateArray()
{
    int[] array = new int[new Random().Next(4, 11)];
    return array;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(-99, 100);
    }
}

int sumOfOddPosition(int[] arr)
{
    int total = 0;
    for(int i = 1; i < arr.Length; i = i + 2)
    {
        total = total + arr[i];
    }
    return total;
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