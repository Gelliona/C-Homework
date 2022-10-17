// Программа выводит построчно элементы массива 2х2х2 с их индексами

Console.Clear();

int[,,] matrix = new int[2, 2, 2];

FillArray(matrix);
PrintArray(matrix);


void FillArray(int[,,] array)
{
    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = generator.Next(10, 100);
            }
        }
    }
}


void PrintArray(int[,,] array)
{
    for (int k=0; k < array.GetLength(2); k++)
    {
        for (int i=0; i < array.GetLength(0); i++)
        {
            for (int j=0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
