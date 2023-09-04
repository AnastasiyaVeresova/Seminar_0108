// Пользователь вводит с клавиатуры M чисел. Считаем, сколько чисел больше 0 ввел пользователь

int quantityNumbersMoreZero(int[] Arr)
{
    int i = 0;
    int count = 0;
    while (i <Arr.Length)
    {
        if (Arr[i] > 0)
        count ++;
        i++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


Console.WriteLine($"Введите количество отрицательных и/или положительных чисел в массиве:");
int m = Convert.ToInt32(Console.ReadLine());

int[] Arr = new int[m];

void Massive(int m)
{
    for(int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
    Arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Massive(m);
PrintArray(Arr);
Console.WriteLine($" -> Вы ввели {quantityNumbersMoreZero(Arr)} чис(-ла,ло,ел) больше 0");