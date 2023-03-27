  //вариант 1
//Просим ввести два числа
// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()??"0");
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()??"0");

// if(num2%num1 == 0)
// {
//     Console.WriteLine("Второе число кратно первому");
// }
// else
// {
//     Console.WriteLine("Второе число не кратно первому, остаток: " + num2%num1);
// }
// //вариант 2
// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()??"0");
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()??"0");

// bool res = (num2%num1 == 0);
// if (res)
// {
//      Console.WriteLine("Второе число кратно первому");
// }
// else
// {
//     Console.WriteLine("Второе число не кратно первому, остаток: " + num2%num1);
// }

// int num1 = int.Parse(Console.ReadLine()??"0"); //faster
// int num2 = int.Parse(Console.ReadLine()??"0");
// bool res = (num1%num2 ==0);
// if(res)
// {
//      Console.WriteLine("Второе число кратно первому");
//  }
//  else
// {
//      Console.WriteLine("Второе число не кратно первому, остаток: ");
//  }

// Console.WriteLine("Введите числа");

// string? num1 = Console.ReadLine();
// string? num2 = Console.ReadLine();

// if ((num1 != null) && (num2 != null))
// {

//     int num01 = int.Parse(num1);
//     int num02 = int.Parse(num2);


//     if (num01 % (num02 * 0.1) = 0)
//     {
//         Console.WriteLine($"Число {num1} кратно {num2}");
//     }
//     else
//     {
//         Console.WriteLine($"Остаток {num01 % num02 * 0.1}");
// //     }
// Console.WriteLine("Введите числа");

// string? num1 = Console.ReadLine();
// string? num2 = Console.ReadLine();

// if ((num1 != null) && (num2 != null))
// {
//     int num01 = int.Parse(num1);
//     int num02 = int.Parse(num2);

//     if (num01 % (num02) == 0) 
//     {
//         Console.WriteLine($"Число {num1} кратно {num2}");
//     }
//     else//if (num01 % (num02 ) != 0) 
//     {
//     Console.WriteLine($"Остаток {num01 % num02 }");
//     }
// }

// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число некратно первому, 
// то программа выводит остаток от деления.

float n1 = float.Parse(Console.ReadLine()??"0");
float n2 = float.Parse(Console.ReadLine()??"0");
// int n2 = Convert.ToInt32(Console.ReadLine());

if (n2%n1==0)
{
    Console.WriteLine("n2 кратно n1");
}
else
{
    Console.WriteLine(n2%n1);
}