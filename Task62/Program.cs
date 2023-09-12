/* Программа заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/



        int n = 4;
        int[,] spiralArray = new int[n, n];

        int maxValue = n * n; 
        int minValue = 1; 
        int currentRow = 0; 
        int currentCol = 0;
        int direction = 0; 
        while (minValue <= maxValue)
        {
            spiralArray[currentRow, currentCol] = minValue;

            
            if (direction == 0 && (currentCol >= n - 1 || spiralArray[currentRow, currentCol + 1] != 0))
            {
                direction = 1; 
            }
            else if (direction == 1 && (currentRow >= n - 1 || spiralArray[currentRow + 1, currentCol] != 0))
            {
                direction = 2; 
            }
            else if (direction == 2 && (currentCol <= 0 || spiralArray[currentRow, currentCol - 1] != 0))
            {
                direction = 3; 
            }
            else if (direction == 3 && (currentRow <= 0 || spiralArray[currentRow - 1, currentCol] != 0))
            {
                direction = 0; 
            }

            
            if (direction == 0)
            {
                currentCol++;
            }
            else if (direction == 1)
            {
                currentRow++;
            }
            else if (direction == 2)
            {
                currentCol--;
            }
            else if (direction == 3)
            {
                currentRow--;
            }

            minValue++;
        }

       
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{spiralArray[i, j]:D2} ");
            }
            Console.WriteLine();
        }
