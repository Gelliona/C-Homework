// Программа создаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементами

Console.Clear();

double[] array = CreateArray();
FillArray(array);
PrintArray(array);

double diff = DifferenceMaxMin(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным значением равна {diff}");


double[] CreateArray()
{
    double[] array = new double[new Random().Next(10, 21)];
    return array;
}

void FillArray(double[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().NextDouble();
    }
}


double DifferenceMaxMin (double[] arr)
{
    double maximum = arr[0];
    double minimum = arr[0];
    for(int i = 1; i < arr.Length; i++ )
    {
        if (arr[i] > maximum)
        {
            maximum = arr[i];
        }
        else if (arr[i] < minimum)
        {
            minimum = arr[i];
        }
    }
    double difference = maximum - minimum;
    return difference;
}


void PrintArray(double[] array)
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
