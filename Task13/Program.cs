// Напишите программу, которая
// выводит третью цифру заданного числа или сообщает, что третьей цифры нет


int ThreeDigit(int num)
{
    int secondDigit = num % 100;
    int thirdDigit = secondDigit % 10;
    return (thirdDigit);
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999)
{
    number = number / 10;

if (number > 99 && number < 1000)
    {
    int result = ThreeDigit(number);
    Console.WriteLine($"Третья цифра числа -> {result}");
    }
}

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
