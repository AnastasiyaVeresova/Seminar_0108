// Формируем трёхмерный массив из неповторяющихся двузначных чисел. Программа построчно выводит массив, добавляя индексы каждого элемента.


void CreateMatrixRndInt(int[,,] matrix)
{
    int count = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] += count;
                count += 3;
            }

        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int depth = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine();
            for (int k = 0; k < depth; k++)
            {
                Console.Write($" {matrix[i, j, k],5} ({i}, {j}, {k}) ");
            }
        }

    }
}

int[,,] matrixDepth = new int[3, 3, 3];
CreateMatrixRndInt(matrixDepth);
PrintMatrix(matrixDepth);