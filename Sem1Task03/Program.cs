// Console.WriteLine("Введите день недели");

// string? inLine = Console.ReadLine();

// if (inLine != null)
// {
//     int inNumber = int.Parse(inLine);

//     if (inNumber == 1)
//     {
//         Console.WriteLine("Понедельник");
//     }
//     if (inNumber == 2)
//     {
//         Console.WriteLine("Вторник");
//     }
//     if (inNumber == 3)
//     {
//         Console.WriteLine("Вторник");
//     }
//     if (inNumber == 4)
//     {
//         Console.WriteLine("Вторник");
//     }
//     if (inNumber == 5)
//     {
//         Console.WriteLine("Вторник");
//     }
//     if (inNumber == 6)
//     {
//         Console.WriteLine("Вторник");
//     }
//     if (inNumber == 7)
//     {
//         Console.WriteLine("Вторник");
//     }

// }

// Console.WriteLine("Put week day");
// string? dayLine = Console.ReadLine();

// if (dayLine!= null)
// {
//     string[] dayweek = new string[7];
//     dayweek[0] = "Mon";
//     dayweek[1] = "Tue";
//     dayweek[2] = "Wed";
//     dayweek[3] = "Thu";
//     dayweek[4] = "Fri";
//     dayweek[5] = "Sat";
//     dayweek[6] = "Sun";
//     int day = int.Parse(dayLine);
//     Console.WriteLine(dayweek[day-1]);
// }

// Console.WriteLine("Введите день недели");
// string? dayLine = Console.ReadLine();

// if (dayLine != null) {
//     string[] dayWeek = new string[7];
//     dayWeek[0] = "Понедельник";
//     dayWeek[1] = "Вторник";
//     dayWeek[2] = "Среда";
//     dayWeek[3] = "Четверг";
//     dayWeek[4] = "Пятница";
//     dayWeek[5] = "Суббота";
//     dayWeek[6] = "Воскресенье";

//     int day = int.Parse(dayLine);

//     if ((0 < day) && (day < 8)) {
//         Console.WriteLine(dayWeek[day-1]);
//     }
//     else Console.WriteLine("Неправильный день недели");

// }

Console.WriteLine("Введите день недели");
//Считываем данные с консоли
string? inputLine = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));
    // Выводим данные в консоль 
    Console.WriteLine(outDayOfWeek);

}