// Программа находит в массиве:
// - количество элементов самой длинной последовательности
// - элемент самой последовательности
// - индекс элемента, который является ее началом.

Console.Clear();

int[] array = {2, 3, 3, 5, 5, 5, 8, 8, 8, 7, 7, 7, 7, 7};
PrintArray(array);

int[] total = FindSequence(array);
Console.WriteLine();
Console.WriteLine($"Count: {total[0]}");
Console.WriteLine($"Element: {total[1]}");
Console.WriteLine($"Position: {total[2]}");


void PrintArray(int[] array)
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

int[] FindSequence(int[] arr)
{
    int seqCount = 1;              // Длина максимальной последовательности
    int seqNum = arr[0];           // Элемент максимальной последовательности
    int seqIndex = 0;              // Индекс первого элемента максимальной последовательности
    int index = 0;                 // Переменная запоминает индекс первого элемента каждой новой последовательности
    int counter = 1;               // Счетчик элементов в каждой новой последовательности

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] != arr[i - 1])
        {
            if (counter > seqCount)
            {
                seqCount = counter;
                seqNum = arr[i - 1];
                seqIndex = index;
            }
            index = i;
            counter = 1;
        }
        else
            counter++;
    }
    if (counter > seqCount)             // Так как цикл закончился и уже не с чем сравнить последний элемент, то отдельно сравниваем счетчик с предыдущим значением seqCount 
    {
        seqCount = counter;
        seqNum = arr[arr.Length - 1];
        seqIndex = index;
        }
    int[] total = {seqCount, seqNum, seqIndex};   
    return total;
}