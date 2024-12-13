/*
using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 2, 4, 3, 2, 5, 3, 3 };
        int mostFrequentElement = FindMostFrequentElement(array);
        Console.WriteLine("Часто встречающийся элемент: " + mostFrequentElement);
    }
        static int FindMostFrequentElement(int[] array)
    {
        int mostFrequent = array[0]; 
        int maxCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = array[i];
            }
        }

        return mostFrequent;
    }
}
*/
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] transposed = Transpose(matrix);
        PrintMatrix(transposed);
    }

    static int[,] Transpose(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[j, i] = matrix[i, j];

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }
}
