// Программа принимает от пользователя положительные числа, пока не будет введено "-1", и выдаёт среднее арифметическое введённых чисел

Console.Clear();

double averageNum = Average();
Console.WriteLine(averageNum);




double Average(double summa = 0, int counter = 0)     
{
    Console.Write("Введите число: ");
    double number = double.Parse(Console.ReadLine()!);

    if (number == -1) 
        return summa / counter;
    else
    {
        return Average(summa+number, ++counter);   
    }
}
