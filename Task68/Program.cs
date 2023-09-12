int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
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

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine();
    }
}

void SumElementsInEachRows(int[,] array)
{
int minRow = 0;
int minSumRow = 0;
int sumRow = 0;
 int [] sumNumbersRows = new int[array.GetLength(0)];
    Console.Write("Суммы элементов в каждой строке: ");

for (int i = 0; i < array.GetLength(1); i++)
{
    minRow += sumNumbersRows[i];
}
for (int i = 0; i < array.GetLength(0); i++)
{
    
    for (int j = 0; j < array.GetLength(1); j++) sumRow += sumNumbersRows[i];
    
     Console.Write($"{sumNumbersRows[i]} ");

    if (sumRow < minRow)
    {
        minRow = sumRow;
        minSumRow = i + 1;
    }
    sumRow = 0;
}
Console.WriteLine($"Наименьшая сумма элементов в строке: {minSumRow}");

}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrix);
SumElementsInEachRows(matrix);
