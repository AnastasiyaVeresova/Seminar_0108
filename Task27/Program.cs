// программа на вход принимает число и выдает сумму цифр в числе


int NumbersSum(int num)
{

    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10;
        sum = sum + digit;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {number} = {NumbersSum(number)}");
