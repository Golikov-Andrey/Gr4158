// string? number = Console.ReadLine();
// if (number != null)
// {
//     int endNum = int.Parse(number);
//     int startNum = endNum * -1;
//     string res = string.Empty;

//     while (startNum<=endNum)
//     {
//        res = res + startNum + " ";
//        startNum = startNum + 1;
//        //startNum++;
//     }

//     Console.WriteLine(res);
// }

//Выводим запрос на ввод числа
Console.Write("Введите число: ");
//Считываем данные с консоли
string? numLine = Console.ReadLine(); //операционная система общается строками, поэтому int сразу не пишем

if(numLine!=null)
{
    int numN = int.Parse(numLine);

    int startNum = numN*(-1);

    string res = string.Empty;
    
    while(startNum <= numN)
    {
        res = res + startNum + " ";
        startNum++;
    }

    Console.WriteLine(res);

}