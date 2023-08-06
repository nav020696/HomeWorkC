Console.WriteLine("Введите первое число");
int numberFirst = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSecond = int.Parse(Console.ReadLine());

Console.WriteLine(numberFirst > numberSecond ? "Максимальное число первое: " + numberFirst : "Максимальное число второе: " + numberSecond);
