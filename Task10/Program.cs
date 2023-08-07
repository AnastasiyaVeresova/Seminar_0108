// Напишите программу, которая
// принимает на вход трехзначное число и на выходе
// показывает вторую цифру этого числа
int SecondDigit(int num)
{
    int secondDigit = num % 100 / 10;
    return (secondDigit);
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа -> {result}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}

