// Задаем двумерный массив m * n, заполненный случайными вещественными числами

double[,] CreateMatrixRndDouble(int m, int n, int min, int max) 
{
    double[,] matrix = new double[m, n]; 
    Random rnd = new Random();

    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            
            matrix[i, j] = rnd.Next(min, max + 1) + rnd.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j], 7:F2}");
        }
        Console.WriteLine();
    }
}

double[,] array = CreateMatrixRndDouble(3, 4, -100, 100);
PrintMatrixDouble(array);