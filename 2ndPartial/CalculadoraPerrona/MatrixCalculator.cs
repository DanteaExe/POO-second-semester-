namespace CalculadoraPerrona
{
    public class MatrixCalculator
    {
        public static double[,] CreateMatrix(int rows, int cols)
        {
            double[,] matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Write($"Add The element: [{i},{j}]: ");
                    matrix[i, j] = int.Parse(ReadLine()!);
                }
            }
            return matrix;
        }

        public static void PrintMatrix(double[,] matrix)
        {
            double rows = matrix.GetLength(0);
            double cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Write(matrix[i, j] + "\t");
                }
                WriteLine();
            }
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

        public static void SumMatrices()
        {
            Write("Write how many matrixes would you like to add: ");
            int numMatrices = int.Parse(ReadLine()!);

            if (numMatrices < 2)
            {
                WriteLine("At least 2 matrixes are nedde to make a sum.");
                return;
            }

            Write("Write the number of rows and columns: ");
            int rowscols = int.Parse(ReadLine()!);

            double[,] result = new double[rowscols, rowscols];

            for (int k = 0; k < numMatrices; k++)
            {
                WriteLine($"\nAdd the matrix elements: {k + 1}:");
                double[,] matrix = CreateMatrix(rowscols, rowscols);

                for (int i = 0; i < rowscols; i++)
                {
                    for (int j = 0; j < rowscols; j++)
                    {
                        result[i, j] += matrix[i, j];
                    }
                }
            }

            WriteLine("\nResult: ");
            PrintMatrix(result);
        }

        public static void MultiplyMatrices()
        {
            Write("Write how many matrixes would you like to multiply: ");
            int numMatrices = int.Parse(ReadLine()!);

            if (numMatrices < 2)
            {
                WriteLine("At least 2 matrixes are needed to multiply");
                return;
            }

            double[,]? result = null;

            for (int k = 0; k < numMatrices; k++)
            {
                WriteLine($"\nMatriz {k + 1}:");
                if (k is 0)
                {
                    Write("Write number of rows: ");
                    int rows = int.Parse(ReadLine()!);
                    Write("Write number of columns: ");
                    int cols = int.Parse(ReadLine()!);
                    result = CreateMatrix(rows, cols);
                }
                else
                {
                    Write($"Add number of columns (number must be: {result!.GetLength(1)}): ");
                    int cols = int.Parse(ReadLine()!);
                    double[,] matrix = CreateMatrix(result.GetLength(1), cols);

                    double[,] temp = new double[result.GetLength(0), cols];

                    for (int i = 0; i < result.GetLength(0); i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            for (int m = 0; m < result.GetLength(1); m++)
                            {
                                temp[i, j] += result[i, m] * matrix[m, j];
                            }
                        }
                    }

                    result = temp;
                }
            }

            WriteLine("\nResult: ");
            PrintMatrix(result!);
        }

        public static void RunMatrixCalculator()
        {
            while (true)
            {
                WriteLine("1. Sum matrixes");
                WriteLine("2. Multiply Matrixes");
                WriteLine("3. Exit");
                Write("Select and option: ");

                string choice = ReadLine()!;

                switch (choice)
                {
                    case "1":
                        SumMatrices();
                        break;
                    case "2":
                        MultiplyMatrices();
                        break;
                    case "3":
                        return;
                    default:
                        WriteLine("That is not a valid option.");
                        break;
                }
            }
        }
    }
}