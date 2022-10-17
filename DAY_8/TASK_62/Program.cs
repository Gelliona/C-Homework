// Программа спирально заполняет массив 4х4

Console.Clear();

int[,] matrix = new int[4, 4];
 

FillArray(matrix);
PrintArray(matrix);


void FillArray(int[,] array)
{
    int count = 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] = count;
        count++;
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, 3] = count;
        count++;
    }
    for (int j = 2; j >= 0; j--)
    {
        array[3, j] = count;
        count++;
    }
    for (int i = 2; i > 0; i--)
    {
        array[i, 0] = count;
        count++;
    }
        for (int j = 1; j < 3; j++)
    {
        array[1, j] = count;
        count++;
    }
        for (int j = 2; j > 0; j--)
    {
        array[2, j] = count;
        count++;
    }
}

void PrintArray(int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
