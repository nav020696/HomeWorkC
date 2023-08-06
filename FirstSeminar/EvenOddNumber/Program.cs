Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(number % 2 == 0 ? "Число " + number + " четное" : "Число " + number + " нечетное");