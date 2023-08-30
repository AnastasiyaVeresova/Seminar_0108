// Задаем массив вещественных чисел и находим разницу между максимальным и минимальным элементом массива


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}


double DiffMaxMinElem(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
        if(arr[i] > max) max = arr[i];
    }
    return max - min;
}

double[] array = CreateArrayRndDouble(5, 2, 99);
PrintArrayDouble(array);
double res = DiffMaxMinElem(array);
Console.Write($" Разница между максимальным и минимальным элементом -> {res:F1}");