double[] Gen1DArray(int len, int min, int max)
{
    double[] arr = new double[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    return arr;
}

//Метод, выводящий на печать массив
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

double[] tesatArray = Gen1DArray(123,0,50);
Print1DArr(tesatArray);