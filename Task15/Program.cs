// Напишите программу, которая
// принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным

// Console.WriteLine("Введите порядковый номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0 && number < 6)
// {
//     Console.WriteLine("Нет");
// }
// if (number > 5 && number < 8)
// {
//     Console.WriteLine("Да");
// }
// if (number > 7 || number < 1)
// {
//     Console.WriteLine("Вы ввели неверное число. Введите порядковый номер дня недели: ");
// }

bool TrueNumber(int num)
{
    return (num > 5 && num < 8);
}

Console.WriteLine("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Вы ввели неверное число. Ожидается порядковый номер дня недели от 1 до 7");
}
else
{
    bool day = TrueNumber(number);
    Console.WriteLine(day? "Да" : "Нет");
}





