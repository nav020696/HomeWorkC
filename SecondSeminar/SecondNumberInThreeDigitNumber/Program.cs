int number = new Random().Next(100,1000);

Console.WriteLine($"Заданное число: {number}");
Console.WriteLine($"Вторая цифра числа: {(number / 10) % 10}");