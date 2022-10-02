// Программа заполняет массив случайными положительными трехзначными числами и показывает количество четных чисел в массиве

Console.Clear();

int[] array = CreateArray();
FillArray(array);
PrintArray(array);
int evenNumbers = sumOfEven(array);
Console.WriteLine();
Console.WriteLine($"В массиве {evenNumbers} четных элементов");


int[] CreateArray()
{
    int[] array = new int[new Random().Next(10, 21)];
    return array;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
    }
}

int sumOfEven(int[] arr)
{
    int counter = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
            counter++;
    }
    return counter;
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
