// Задаем массив, заполненный случайными положительными и трехзначными числами.
//Программа показывает количество четных чисел в массиве.

int[] CreatePozitiveThreedigit(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i =0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}

int PozitiveCountDigit(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0 ) count++;
    }
    return count;
}

int[] array = CreatePozitiveThreedigit(4, 100, 999);
PrintArray(array);
int result = PozitiveCountDigit(array);
Console.Write($"Количество четных чисел в массиве -> {result}");