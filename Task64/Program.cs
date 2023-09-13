/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Validation(int num)
{
    while (num < 1)
    {
        num = Prompt("Неверно введено число. Введите натуральное число: ");
    }
    return num;
}

int NaturalNumbers(int num)
{
    if (num == 1) return 1;
    Console.Write($"{num} ");
    return NaturalNumbers(num - 1);
}

int number = Prompt("Введите натуральное число: ");
number = Validation(number);


Console.WriteLine(NaturalNumbers(number));
