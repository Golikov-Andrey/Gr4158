// string? numLine1 = Console.ReadLine();
// string? numLine2 = Console.ReadLine();

// if (numLine1 != null && numLine2 != null)
// {
//     int num1 = int.Parse(numLine1);
//     int num2 = int.Parse(numLine2);
//     if (num1 == num2 * num2)
//     {
//         Console.WriteLine("Первое число квадрат ДА");
//     }
//     else
//     {
//         Console.WriteLine("Первое число квадрат НЕТ");
//     }
// }

// string? inLine1 = Console.ReadLine();
// string? inLine2 = Console.ReadLine();
// if ((inLine1 != null) && (inLine2 != null))
// {
//     int inNumber1 = int.Parse(inLine1);
//     int inNumber2 = int.Parse(inLine2);

//     int outNumber2 = inNumber2 * inNumber2;

//     if (outNumber2 == inNumber1)
//     {
//         Console.WriteLine("Да является");
//     }
//     else
//     {
//         Console.WriteLine("Не является");
//     }

// }

// string? firsNumberLine = Console.ReadLine();
// string? secondNumberLine = Console.ReadLine();

// if (firsNumberLine != null && secondNumberLine != null)
// {
//     int firsNumber = int.Parse(firsNumberLine);
//     int secondNumber = int.Parse(secondNumberLine);

//     if (firsNumber == (int)Math.Pow(secondNumber, 2))
//     {
//         Console.WriteLine("Yes");
//     }
//     else
//     {
//         Console.WriteLine("No");
//     }
// }

string? inLine1 = Console.ReadLine();
string? inLine2 = Console.ReadLine();
if ((inLine1 != null) && (inLine2 != null))
{
    int inNumber1 = int.Parse(inLine1);

    int inNumber2 = int.Parse(inLine2);

    int outNumber2 = inNumber2 * inNumber2;

    if (outNumber2 == inNumber1)
    {
        Console.WriteLine("Да является");
    }
    else
    {
        Console.WriteLine("Не является");
    }

}