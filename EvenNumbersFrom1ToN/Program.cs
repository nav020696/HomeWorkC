Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int index = 1;

if (number <= index)
{
    Console.WriteLine("Задайте число больше 1");
}

while(index <= number)
{
    if (index % 2 == 0)
    {
        Console.Write(index + " ");
    }
    index++;
}
