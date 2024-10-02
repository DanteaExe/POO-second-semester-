namespace CalculadoraPerrona
{
    public class Gauss
    {
        public static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Write($"{matrix[i, j],8:F4} ");
                }
                WriteLine();
            }
            WriteLine();
        }

        public static double[] GaussJordanElimination(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                int maxRow = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(matrix[k, i]) > Math.Abs(matrix[maxRow, i]))
                    {
                        maxRow = k;
                    }
                }

                for (int k = i; k <= n; k++)
                {
                    (matrix[i, k], matrix[maxRow, k]) = (matrix[maxRow, k], matrix[i, k]);
                }

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = matrix[k, i] / matrix[i, i];
                        for (int j = i; j <= n; j++)
                        {
                            matrix[k, j] -= factor * matrix[i, j];
                        }
                    }
                }

                double divisor = matrix[i, i];
                for (int j = i; j <= n; j++)
                {
                    matrix[i, j] /= divisor;
                }
            }
            double[] solutions = new double[n];
            for (int i = 0; i < n; i++)
            {
                solutions[i] = matrix[i, n];
            }

            return solutions;
        }
    }
}
