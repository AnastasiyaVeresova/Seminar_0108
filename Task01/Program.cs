// _______________________________________
// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго


Console.WriteLine("Введите первое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int numberB = Convert.ToInt32(Console.ReadLine());
int square = numberB * numberB;

if (numberA == square)
{Console.WriteLine($"{square} - квадрат числа {numberB}");}
else{
Console.WriteLine($"{numberA} не является квадратом числа {numberB}");}










