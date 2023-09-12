// Задаем две матрицы. Программа находит произведение двух матриц.

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

void PrintArr(int[,] matrix)
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

void MultiplyArray(int[,] arrayFirst, int[,] arraySecond, int[,] arrayMultiplyResult)
{
     

     for (int i = 0; i < arrayMultiplyResult.GetLength(0); i++)
     {
        for (int j = 0; j < arrayMultiplyResult.GetLength(1); j++)
        {
            
           
                arrayMultiplyResult[i, j] += arrayFirst[i, j] * arraySecond[i, j];
          
        
           
        }
     }
}

int[,] firstArr = CreateMatrixRndInt(3, 4, 0, 10);
int[,] secondArr = CreateMatrixRndInt(3, 4, 0, 10);
int[,] matrixResult = new int[3, 4];

PrintArr(firstArr);
 Console.WriteLine();
PrintArr(secondArr);
MultiplyArray(firstArr, secondArr, matrixResult);
 Console.WriteLine();
 PrintArr(matrixResult);


