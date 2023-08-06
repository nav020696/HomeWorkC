int number = new Random().Next(1,8);

switch (number)
{   
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine($"{number} день недели не выходной");
        break;
    case 6:
    case 7:
        Console.WriteLine($"{number} день недели выходной");
        break;
    default:
        Console.WriteLine("Нет дня недели с таким номером");
        break;
}
