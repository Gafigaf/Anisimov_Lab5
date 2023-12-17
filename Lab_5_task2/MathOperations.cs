using System;

namespace Lab_5_task2
{
    public class MathOperations
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        
        public double[] Add(double[] a, double[] b)
        {
            if (a.Length != b.Length)
            {
                throw new ArgumentException("Arrays must be of the same length");
            }

            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] + b[i];
            }

            return result;
        }
        
        public double[,] Add(double[,] a, double[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            if (rows != b.GetLength(0) || cols != b.GetLength(1))
            {
                throw new ArgumentException("Matrices must be of the same size");
            }

            double[,] result = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }
        
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        
        public double[] Subtract(double[] a, double[] b)
        {
            if (a.Length != b.Length)
            {
                throw new ArgumentException("Arrays must be of the same length");
            }

            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] - b[i];
            }

            return result;
        }
        
        public double[,] Subtract(double[,] a, double[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            if (rows != b.GetLength(0) || cols != b.GetLength(1))
            {
                throw new ArgumentException("Matrices must be of the same size");
            }

            double[,] result = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }

            return result;
        }
        
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        
        public double[] Multiply(double[] a, double[] b)
        {
            if (a.Length != b.Length)
            {
                throw new ArgumentException("Arrays must be of the same length");
            }

            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] * b[i];
            }

            return result;
        }
        
        public double[,] Multiply(double[,] a, double[,] b)
        {
            int aRows = a.GetLength(0);
            int aCols = a.GetLength(1);
            int bRows = b.GetLength(0);
            int bCols = b.GetLength(1);

            if (aCols != bRows)
            {
                throw new ArgumentException(
                    "Number of columns in first matrix must be equal to number of rows in second matrix");
            }

            double[,] result = new double[aRows, bCols];
            for (int i = 0; i < aRows; i++)
            {
                for (int j = 0; j < bCols; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < aCols; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }
    }
}