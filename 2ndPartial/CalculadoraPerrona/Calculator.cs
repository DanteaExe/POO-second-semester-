using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace CalculadoraPerrona
{
    public partial class Calculator
    {
        //Regex helps to analize big cuantities of text to search an specific character
        [GeneratedRegex(@"(sin|cos|tan)\((-?\d+(\.\d+)?)\)")]
        private static partial Regex TrigRegex();

        [GeneratedRegex(@"^(-?\d*)\s*X\s*([+-]\s*\d+)?$")]
        private static partial Regex EquRegex();
        public static string ReplaceTrigFunctions(string expression)
        {
            return TrigRegex().Replace(expression, match =>
            {
                string function = match.Groups[1].Value;
                double angle = double.Parse(match.Groups[2].Value);
                double radians = angle * (Math.PI / 180.0);

                double result = function == "sin" ? Math.Sin(radians) :
                                function == "cos" ? Math.Cos(radians) :
                                Math.Tan(radians);

                return result.ToString();
            });
        }
        public static double EvaluateExpression(string expression)
        {
            DataTable table = new();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        public static void SolveAlgebraicEquation(string equation)
        {
            string[] sides = equation.Split('=');
            if (sides.Length is not 2)
            {
                throw new ArgumentException("Expression must have a sign '='");
            }

            Match match = EquRegex().Match(sides[0].Trim());
            if (!match.Success)
            {
                throw new ArgumentException("Equation format was not valid, must be:  'aX + b = c'");
            }

            double coefficientX = string.IsNullOrEmpty(match.Groups[1].Value) ? 1 : double.Parse(match.Groups[1].Value);
            double constantTerm = match.Groups[2].Success ? double.Parse(match.Groups[2].Value.Replace(" ", "")) : 0;
            double rightSide = double.Parse(sides[1].Trim());

            double x = (rightSide - constantTerm) / coefficientX;
            WriteLine($"X value is: {x}");
        }
    }
}