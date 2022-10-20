// Программа спирально заполняет массив произвольного размера

Console.Clear();

Random lengthGenerator = new Random();
int[,] matrix = new int[lengthGenerator.Next(2,10), lengthGenerator.Next(2,10)];  


FillArray(matrix);
PrintArray(matrix);


void FillArray(int[,] array)
{
    int count = 1;
    int constanta = 0;                                                           // Константа смещения координат каждого круга. Для каждого круга увеличивается на 1.
    int gorizontalPathLength = array.GetLength(1);                               // Размер круга по горизонтали, который мы обходим. Для каждого круга уменьшается на 1. 
    int verticalPathLength = array.GetLength(0);                                 // Размер круга по вертикали, который мы обходим. Для каждого круга уменьшается на 1.                      
    while (count <= array.GetLength(0) * array.GetLength(1))                     // Пока не закончились цифры для заполнения.
    {
        for (int j =  constanta; j < gorizontalPathLength; j++)                  // Движение вправо
        {
            if (count > array.GetLength(0) * array.GetLength(1))
                break;
            else
            {
                array[constanta, j] = count;
                count++;
            }
            
        }
        for (int i = 1 + constanta; i < verticalPathLength; i++)                 // Движение вниз
        {
            if (count > array.GetLength(0) * array.GetLength(1))
                break;
            else
            {
                array[i, gorizontalPathLength - 1] = count;
                count++;
            }

        }
        for (int j = gorizontalPathLength - 2; j >= constanta; j--)              // Движение влево
        {
            if (count > array.GetLength(0) * array.GetLength(1))
                break;
            else
            {
                array[verticalPathLength - 1, j] = count;
                count++;
            }

        }
        for (int i = verticalPathLength - 2; i > constanta; i--)                 // Движение вверх
        {
            if (count > array.GetLength(0) * array.GetLength(1))
                break;
            else
            {
                array[i, constanta] = count;
                count++;
            }

        }
        constanta++;
        gorizontalPathLength = gorizontalPathLength - 1;
        verticalPathLength = verticalPathLength - 1;
        
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
