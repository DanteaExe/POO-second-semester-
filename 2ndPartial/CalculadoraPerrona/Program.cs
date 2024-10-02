using CalculadoraPerrona;

while (true)
{
    WriteLine("Enter an expretion, if is an equation must be(aX + b = c) or type 'exit' to finish:");
    string? input = ReadLine();

    if (input?.ToLower() is "exit")
    {
        break;
    }

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
}