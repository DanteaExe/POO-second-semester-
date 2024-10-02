using CalculadoraPerrona;

Clear();
ShowMenu();
WriteLine("Write the option you want: ");
string? option = ReadLine();

switch (option)
{
    case "1":
        Clear();
        WriteLine("Enter an expretion, if is an equation must be(aX + b = c)");
        string? input = ReadLine();
        try
        {
            if (input!.Contains('='))
            {
                Calculator.SolveAlgebraicEquation(input);
            }
            else
            {
                string expression = Calculator.ReplaceTrigFunctions(input);
                double result = Calculator.EvaluateExpression(expression);
                WriteLine("Result: " + result);
            }
        }
        catch (Exception ex)
        {
            WriteLine("Something went wrong: " + ex.Message);
        }
        break;

    case "2":
        Clear();
        WriteLine("Insert the number of equations: ");
       int numEquations = int.Parse(ReadLine()!);

            if (numEquations < 2 || numEquations > 10)
            {
                WriteLine("This program only solves systems of equations between 2x2 and 10x10.");
                return;
            }

            double[,] augmentedMatrix = new double[numEquations, numEquations + 1];

            WriteLine("Enter the coefficients and constants for each equation:");
            for (int i = 0; i < numEquations; i++)
            {
                WriteLine($"Equation {i + 1}:");
                for (int j = 0; j < numEquations; j++)
                {
                    Write($"Coefficient for x{j + 1}: ");
                    augmentedMatrix[i, j] = double.Parse(ReadLine()!);
                }
                Write("Constant term: ");
                augmentedMatrix[i, numEquations] = double.Parse(ReadLine()!);
            }

            WriteLine();
            WriteLine("Augmented Matrix:");
            Gauss.PrintMatrix(augmentedMatrix);

            double[] solutions = Gauss.GaussJordanElimination(augmentedMatrix);

            if (solutions is null)
            {
                WriteLine("The system has no unique solution.");
            }
            else
            {
                WriteLine("The solutions are:");
                for (int i = 0; i < numEquations; i++)
                {
                    WriteLine($"x{i + 1} = {solutions[i]}");
                }
            }
        break;

    case "3":
        Clear();
        WriteLine("Byeeee");
        break;

    default:
        WriteLine("That is not an option");
        break;
}

void ShowMenu()
{
    WriteLine("1.- Simple math expretion/equation");
    WriteLine("2.- Matrix");
    WriteLine("3.- Exit");
}