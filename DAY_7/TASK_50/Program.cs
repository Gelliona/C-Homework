// Программа принимает на вход значения позиции элемента в заданном массиве и выводит нужный элемент


Console.Clear();

Console.Write("Введите номер строки: ");    // Поскольку речь идет не об индексе, а о номере, то элемент в строке 1 и стобце 1 соответствует элементу с индексом (0,0)
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца: ");
int n = int.Parse(Console.ReadLine()!);

Random lengthGenerator = new Random();
int[,] array = new int[lengthGenerator.Next(2,10), lengthGenerator.Next(2,10)];    // Размер массива задаётся случайным образом

FillArray(array);
PrintArray(array);

FindNumber(array, m, n);


void PrintArray(int[,] array)
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


void FillArray(int[,] array)
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

void FindNumber(int[,] array,int m, int n)
{
    if ((m > array.GetLength(0)) || (n > array.GetLength(1)))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(i==(m-1) && j==(n-1))
                {
                    Console.WriteLine(array[i,j]);
                }
            }
        } 
    }
}
