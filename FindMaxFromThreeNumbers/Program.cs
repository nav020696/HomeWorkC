Console.WriteLine("Введите первое число");
int numberFirst = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSecond = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberThird = int.Parse(Console.ReadLine());
int max = numberFirst;

if (numberSecond > max)
{
    max = numberSecond;
}

if (numberThird > max)
{
    max = numberThird;
}

Console.WriteLine("Максимальное число: " + max);