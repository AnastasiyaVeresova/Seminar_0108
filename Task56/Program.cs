// Задаем прямоугольный двумерный массив. Программа находит строку с наименьшей суммой элементов.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int SumElementsInEachRows(int[,] array)
{
    int[] sumNumbersRows = new int[array.GetLength(0)];
    Console.WriteLine("Сумма элементов по строкам: ");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumNumbersRows[i] += array[i, j];

        }
        Console.WriteLine($"{i + 1} -> {sumNumbersRows[i]} ");
    }

    int minSum = sumNumbersRows[0];
    int minRow = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sumNumbersRows[i] < minSum)
        {
            minSum = sumNumbersRows[i];
            minRow = i + 1;
        }
    }
    return minRow;
}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 10);

PrintMatrix(matrix);
int rowNumber = SumElementsInEachRows(matrix);
Console.WriteLine($"Наименьшая сумма элементов в строке: {rowNumber}");

