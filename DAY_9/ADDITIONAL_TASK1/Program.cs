// Заданы 2 массива: info и data. В массиве data хранятся двоичные представления нескольких чисел (без разделителя). В массиве info хранится информация о количестве бит,
// которые занимают числа из массива data. Программа составляет массив десятичных представлений чисел массива data с учетом информации из массива info.
// data = {0,1,1,1,1,0,0,0,1}
// info = {2,3,3,1}
// выходные данные: 1, 7, 0, 1

Console.Clear();

int[] data = new int[] {0,1,1,1,1,0,0,0,1};
int[] info = new int[] {2,3,3,1};

PrintArray(data);
Console.WriteLine();
PrintArray(info);
Console.WriteLine();

int[] decimalArray = BinToDecimal(data, info);

PrintArray(decimalArray);


int[] BinToDecimal(int[] firstArray, int[] secondArray)
{
    int[] result = new int[secondArray.Length];
    int count = 0;
 
    for (int i = 0; i < secondArray.Length; i++)
    {
        int[] temp = new int[secondArray[i]];
        double decimalNumber = 0;

        for(int j = 0; j < temp.Length; j++)
        { 
            temp[j] = firstArray[count];
            decimalNumber  = decimalNumber + Math.Pow(2,j) * temp[j];
            count++;
        }
        result[i] = Convert.ToInt32(decimalNumber);
    }
    return result;   
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1)
        Console.Write($", ");
    }
}
