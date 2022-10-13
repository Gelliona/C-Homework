// Программа выводит среднее арифметическое элементов в каждом столбце заданного массива

Console.Clear();

Random lengthGenerator = new Random();
double[,] array = new double[lengthGenerator.Next(3,10), lengthGenerator.Next(3,10)];    // Размер массива задаётся случайным образом

FillArray(array);
PrintArray(array);

double[] average = FindAverage(array);
Console.WriteLine();
PrintAverage(average);


void PrintArray(double[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
}

double[] FindAverage(double[,] array, double summa = 0)
{

    double[] averageArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summa = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summa = summa + array[i,j];
        }
        averageArray[j] = Math.Round((summa / array.GetLength(0)),2);
       
    } 
    return averageArray;
}

void PrintAverage(double[] array)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1)
        Console.Write($"; ");
    }
}
