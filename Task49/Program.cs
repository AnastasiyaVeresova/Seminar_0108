// // Задаем двумерный массив. Находим элементы, у
// которых оба индекса чётные, и заменяем эти элементы на их
// квадраты.


int[,] CreateMatrixSumIndexes(int rows, int columns,int min, int max) 
{ 
    int[,] matrix = new int[rows, columns]; 
    Random rand = new Random(); 
    for(int i = 0; i < rows; i++) 
    { 
        for(int j = 0; j < columns; j++) 
        { 
            matrix[i, j] = rand.Next(min,max+1); 
        } 
    } 
    return matrix; 
} 
 
void PrintArray(int[,] arr) 
{ 
    int rows = arr.GetLength(0); 
    int columns = arr.GetLength(1); 
 
    for(int i = 0; i < rows; i++) 
    { 
        for(int j = 0; j < columns; j++) 
        { 
            Console.Write($"{arr[i, j], 5}"); 
        } 
        Console.WriteLine(); 
    } 
} 
void EvenIndicesInPow(int[,] matrix) 
{ 
    for(int i = 0; i < matrix.GetLength(0); i+=2) 
    { 
        for(int j = 0; j < matrix.GetLength(1); j+=2) 
        { 
            matrix[i, j] *= matrix[i, j]; 
        } 
    } 
} 
 
int[,] matrix = CreateMatrixSumIndexes(3, 4,-5,5); 
PrintArray(matrix); 
EvenIndicesInPow(matrix); 
Console.WriteLine(); 
PrintArray(matrix);