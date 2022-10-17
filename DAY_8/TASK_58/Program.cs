// Программа находит произведение двух матриц. Судя по примеру, имелось в виду не скалярное произведение, а просто перемножение соответствующих элементов.

Console.Clear();

int[,] matrix1 = new int[4, 4];
int[,] matrix2 = new int[4, 4];  

FillArray(matrix1);
FillArray(matrix2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();

int[,] newMatrix = MatrixProduct(matrix1, matrix2);
PrintArray(newMatrix);



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

int[,] MatrixProduct(int[,] array1, int[,] array2)
{
    int[,] product = new int[array1.GetLength(0),array1.GetLength(1)];
    for (int i=0; i < array1.GetLength(0); i++)
    {
        for (int j=0; j < array1.GetLength(1); j++)
        {
            product[i,j] = array1[i,j] * array2[i,j];    
        }
    }
    return product;
}
