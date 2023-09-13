/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void Validation(int num)
{
    while(num < 1)
    {
        num = Prompt("Неверно введено число. Введите натуральное число: ");
    }
}


int FindSumNumbers(int from, int to)
{
    int res = 0;

    if(from == to)
    {
        return res += from;
    }
    else if (from < to)
    {
     return res += from + FindSumNumbers(from + 1, to);
    }
    else
    {
        return res += from + FindSumNumbers(from - 1, to);
    }
}  


Console.WriteLine("Введите диапазон натуральных чисел");

int numberOne = Prompt("Введите натуральное число: ");
Validation(numberOne);

int numberTwo = Prompt("Введите натуральное число: ");
Validation(numberTwo);

int sum = FindSumNumbers(numberOne, numberTwo);

Console.WriteLine(FindSumNumbers(numberOne, numberTwo));
