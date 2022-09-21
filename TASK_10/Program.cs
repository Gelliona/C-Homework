Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());


Console.WriteLine(number / 10 % 10);