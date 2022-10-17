// Программа находит строку массива с наименьшей суммой элементов 

Console.Clear();


Random lengthGenerator = new Random();
int[,] matrix = new int[lengthGenerator.Next(3,5), lengthGenerator.Next(3,5)];   

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

int row = FindRowMinSumma(matrix);
Console.WriteLine($"{row} строка имеет минимальную сумму элементов");   // Нумерация строк начинается с 1



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

int FindRowMinSumma(int[,] array, int summa = 0, int minRow = 0, int minSumma = 1000)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            summa = summa + array [i,j];
        }
        if (summa < minSumma)
        {
            minSumma = summa;
            minRow = i+1;
        }
        summa = 0;
    } 
    return minRow;  
}