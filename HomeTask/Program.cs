

// Console.Clear();

// //Метод ввода 
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// // //Метод заполнение массива
// // int[,] Gen2DArray(int countRow, int countColumn, int but, int top)
// // {

// //     //Защита от дурака
// //     int[,] arr = new int[countRow, countColumn];
// //     for (int i = 0; i < countRow; i++)
// //     {
// //         for (int j = 0; j < countColumn; j++)
// //         {
// //             arr[i, j] = new Random().Next(but, top + 1);
// //         }

// //     }
// //     return arr;
// // }

// ConsoleColor ColorChoose(int colorIn, int i, int j)
// {
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};

//     switch (colorIn)
//     {
//         case 16:
//             return col[new Random().Next(0, 15)];
//         case 17:
//             if ((i + j) % 2 == 0)
//             {
//                 return col[0];
//             }
//             else
//             {
//                 return  col[15];
//             }
//         case < 16:
//             return col[colorIn];       
//     }
//     return ConsoleColor.White;
// }

// int[,] PaintArray(int[,] arr, int colorIn)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = ColorChoose(colorIn, i, j);
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     return arr;
// }

// int row = ReadData("Введите колличество строк: ");
// int col = ReadData("Введите колличество столбцов: ");
// int colorIn = ReadData("В какой цвет вы хотите раскрасить массив \n Черный(0) \n Синий(1) \n Циан(2) \n Темно-Синий(3) \n Темный-Циан(4) \n Темно-Серый(5) \n Темно-Зеленый(6) \n Темный-Маджента(7) \n Темно-красный(8) \n Темно-Желтый(9) \n Серый(10) \n Зеденый(11) \n Маджента(12) \n Красный(13) \n Белый(14) \n Желтый(15) \n Разоцветный(16) \n Шахматы(17) \n Обычный(18 и больше) \n Введите число: ");
// int[,] arr2D = Gen2DArray(row, col, 10, 99);
// arr2D = PaintArray(arr2D, colorIn);

// Console.ResetColor();
// Метод заполнения 2х-мерного массива числами Фибоначчи :
long[,] Fibonacci2Darr(int countRow, int countColumn)
{
    long[,] arr = new long[countRow, countColumn];
    long first = 0;
    long last = 1;
    int k=0;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            if (k < 2)
            {
                arr[0, 0] = 0;
                arr[0, 1] = 1;
                k++;
            }
            else
            {
                arr[i, j] = (first + last);
                (first, last) = (last, first + last);
            }
        }
    }
    return arr;
}

//метод печати двумерного массива
void Print2DArray(long[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}


long[,] arr = Fibonacci2Darr(5,5);
Print2DArray(arr);
