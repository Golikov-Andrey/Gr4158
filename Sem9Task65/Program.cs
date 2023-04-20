Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void FromMToN(int m, int n)
{   
    if (m <= n)
    {
        Console.Write(m + " ");
        FromMToN(m + 1,n);
    }
    else
    {
        return;
    }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

// if (m > n)
// {
//     int buf = m;
//     m = n;
//     n = buf;
// }


//(m>n)?FromMToN(n,m):FromMToN(m,n);
FromMToN((m>n)?n:m,(m>n)?m:n);