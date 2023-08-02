// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите первое целое число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int z = Convert.ToInt32(Console.ReadLine());

int max = x;

if ( x > max ) max = x;
if ( y > max ) max = y;
if ( z > max ) max = z;

Console.WriteLine(max);
