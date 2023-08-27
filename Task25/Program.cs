/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Exponentiation(int num, int exp)
{
    int res = 1;
    for (int i = 1; i <= exp; i++)
    {
        
        res *= num;
    }
    return res;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральную степень, в которую нужно это число возвести");
int exponenta = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(number, exponenta);

if(exponenta < 0)
{
    Console.WriteLine("Введено некорректное число для возведения в степень");
    return;
}

Console.WriteLine($"число {number} в степени {exponenta} = {exponentiation}");


