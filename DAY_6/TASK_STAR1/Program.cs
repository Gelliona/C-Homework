// Программа рекурсивным методом переводит числа из десятичной системы в двоичную

Console.Clear();

Console.Write("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine()!);
int binaryNumber = int.Parse (BinaryConverting(number));
Console.WriteLine(binaryNumber);


string BinaryConverting(int num, string mod = "", string binNum = "")
{
    if (num < 2)
    {
        binNum = 1 + binNum;
        return (binNum);
    }
    else
    {
        mod = Convert.ToString(num % 2);
        binNum = mod + binNum ;
        return BinaryConverting(num/2, mod = "", binNum);
    }
  
}