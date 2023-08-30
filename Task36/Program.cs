//Задаем одномерный массив, заполненный случайными числами и находим сумму элементов, стоящих на нечетных позициях

// Задаем массив, заполненный случайными положительными и трехзначными числами.
//Программа показывает количество четных чисел в массиве.

int[] CreateMassRandomNumbers(int size, int min, int max)
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

int SumNumbersOfOddPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum += arr[i];
       
    }
    return sum;
}

int[] array = CreateMassRandomNumbers(9, 0, 99);
PrintArray(array);
int result = SumNumbersOfOddPosition(array);
Console.Write($"Сумма элементов на нечетных позициях -> {result}");