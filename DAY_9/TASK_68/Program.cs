// Программа вычисляет функцию Аккермана с помощью рекурсии.

Console.Clear();

Console.Write("Введите первое положительное число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе положительное число: ");
int secondNumber = int.Parse(Console.ReadLine()!);

int result = Akkerman(firstNumber, secondNumber);
Console.WriteLine(result);


int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;   
    else if (m > 0 && n == 0)
        return Akkerman(m-1, 1); 
    else 
    {
        return Akkerman(m-1, Akkerman(m, n-1));
    }
}
