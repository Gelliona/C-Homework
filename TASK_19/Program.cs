// Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int Digit1 = number/10000;
int Digit2 = number%10000/1000;
int Digit4 = number%100/10;
int Digit5 = number%10;

bool Palindrom = false;

if (Digit1==Digit5)
{
    if (Digit2==Digit4)
    {
        Palindrom = true;
    }
}


if (Palindrom == true)
{
    Console.WriteLine("Данное число является палиндромом");
}
else
{
    Console.WriteLine("Данное число не является палиндромом");
}    

