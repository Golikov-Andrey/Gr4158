// Console.WriteLine("Введите первое число");
// int num1 = int.Parse(Console.ReadLine()??"0");

// bool res = ((num1%7 == 0) &&(num1%23 == 0));

// if (res)
// {
//   Console.WriteLine("кратно");
// }
// else
// {
//   Console.WriteLine("не кратно");
// }

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()??"0");

// bool res = ((num%7 == 0)&&(num%23==0));
// if (res)
// {
//      Console.WriteLine("Число кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine("Число некратно 7 и 23, остаток от 7: " + num%7 + ", остаток от 23: " + num%23);
// }

// int num = int.Parse(Console.ReadLine()??"0");
// bool test1 = (num%7 == 0);
// bool test2 = (num%23 == 0);
// if (test1 && test2)
// {
//    Console.WriteLine("кратно  оно одновременно 7 и 23.");
// }
// else 
// {
//    Console.WriteLine("не кратно  оно одновременно 7 и 23.");
// }

Console.WriteLine("Введите число");

string? numberStr = Console.ReadLine();
if (numberStr != null)
{
    int numInt = int.Parse(numberStr);
    if (numInt % 7 == 0 && numInt % 23 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Некратно");
    }
}