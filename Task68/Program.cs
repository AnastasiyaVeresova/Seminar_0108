/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
int FunctionAnkerman(int k, int m)
{
    if (k == 0)
    return m + 1;

    else
    {
        if (k !=0 && m == 0)
        return FunctionAnkerman(k - 1, 1);

        else
        {
            return FunctionAnkerman(k - 1, FunctionAnkerman(k, m - 1));
        }
    }
}

int res = FunctionAnkerman(3, 11);
Console.WriteLine(res);