
using System;

class Program
{
    static void Main()
    {
        // Define two 3x3 matrices
        int[,] matrix1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrix2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        // Find the sum of matrices
        int[,] sumMatrix = AddMatrices(matrix1, matrix2);

        // Display the result
        Console.WriteLine("Sum of the matrices:");
        DisplayMatrix(sumMatrix);
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
