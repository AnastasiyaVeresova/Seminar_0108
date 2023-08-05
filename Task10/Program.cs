// Напишите программу, которая
// принимает на вход трехзначное число и на выходе
// показывает вторую цифру этого числа

int SecondDigit(int num) 
{
    int secondDigit = num % 100 / 10;
    return (secondDigit);
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число в диапазоне 100 - 999 -> {number}");

int result = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа -> {result}");

