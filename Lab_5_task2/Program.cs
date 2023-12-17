using System;

namespace Lab_5_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();
            
            Console.WriteLine("Add: " + math.Add(5, 3));
            Console.WriteLine("Subtract: " + math.Subtract(5, 3));
            Console.WriteLine("Multiply: " + math.Multiply(5, 3));
            
            double[] a = { 1, 2, 3 };
            double[] b = { 4, 5, 6 };
            double[] result = math.Add(a, b);
            Console.WriteLine("Add: " + string.Join(", ", result));
            result = math.Subtract(a, b);
            Console.WriteLine("Subtract: " + string.Join(", ", result));
            result = math.Multiply(a, b);
            Console.WriteLine("Multiply: " + string.Join(", ", result));
            
            double[,] c = { { 1, 2 }, { 3, 4 } };
            double[,] d = { { 5, 6 }, { 7, 8 } };
            double[,] matrixResult = math.Add(c, d);
            Console.WriteLine("Add: ");
            PrintMatrix(matrixResult);
            matrixResult = math.Subtract(c, d);
            Console.WriteLine("Subtract: ");
            PrintMatrix(matrixResult);
            matrixResult = math.Multiply(c, d);
            Console.WriteLine("Multiply: ");
            PrintMatrix(matrixResult);
        }

        static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}