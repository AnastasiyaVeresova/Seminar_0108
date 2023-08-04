// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000); // 99 + 1
Console.WriteLine($"Случайное число в диапазоне 100 - 999 -> {number}");

// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10;  // 78 % 10 = 70 + 8

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {result}");
int result = DeleteSecondDigit(number);
Console.WriteLine($"{result}");

int DeleteSecondDigit(int num) // num = number
{
    int firstDigit = num / 100;// 5** 4 5 = 45 4*10 = 40 + 5 = 45
    int secondDigit = num % 10;// **5
    return (firstDigit * 10 + secondDigit);
}