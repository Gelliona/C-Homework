// Программа упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.Clear();


Random lengthGenerator = new Random();
int[,] matrix = new int[lengthGenerator.Next(4,6), lengthGenerator.Next(6,8)];   

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

SortRows(matrix);
PrintArray(matrix);


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

void SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,k] > array[i,j])
                {
                    int num = array[i,k];
                    array[i, k] = array[i, j];
                    array[i, j] = num;
                }
            }
           
        }

    }
}