// Программа задает массив из 8 элементов и выводит их на экран


void FillArr(int[] mass)
{
    int i = 0;
    var random = new Random();
    while(i < mass.Length)
    {
        mass[i] = random.Next(0, 99);
        i++;
    }
}

void PrintArr(int[] mass)
{
    int i = 0;
    while(i < mass.Length - 1)
    {
        Console.Write($"{mass[i]}, ");
        i++;
    }
    Console.Write($"{mass[i]}");
}

void PrintArr2(int[] mass)
{
    int i = 0;
    while(i < mass.Length - 1)
    {
        Console.Write($"{mass[i]}, ");
        i++;
    }
    Console.Write($"{mass[i]}");
}


int[] array = new int[8];
FillArr(array);

PrintArr(array);
Console.Write(" -> [");
PrintArr2(array);
Console.Write("]");

