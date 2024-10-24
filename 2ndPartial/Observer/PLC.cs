using Notifiers;

public class PLC
{
    private static readonly Random rand = new();
    private readonly NormalAlert normalAlert = new();
    private readonly ErrorAlert errorAlert = new();

    public List<bool> GenerateRandElements(List<bool> elements, int size)
    {
        double initialProbability = 0.9; // initial probability
        //reduce probability by step
        //double step = initialProbability / size;
        for (int i = 0; i < size; i++)
        {
            // exponential distribution
            double currentProbability = initialProbability * Math.Pow(0.8, i);
            //linal distribution
            //double currentProbability = initialProbability - (step * i);

            double randomValue = rand.NextDouble();
            elements.Add(randomValue < currentProbability);
        }
        return elements;
    }

    public void PrintElements(List<bool> elements)
    {
        foreach (var item in elements)
        {
            Write(item + ", ");
        }
        WriteLine();
    }

    public string CheckContinuous(List<bool> elements)
    {
        if (elements.Count is 1)
        {
            return elements[0] ? normalAlert.Notify() : errorAlert.Notify();
        }
        //check 2 trues togheter
        bool hasAdjacentTrues = elements.Take(elements.Count - 1)//take n-1 because last has no next
                                                                 //comapre: e actual, i next
                                       .Where((e, i) => e && elements[i + 1])
                                       //true if consecutive
                                       .Any();

        // count how many trues
        int trueCount = elements.Count(e => e);
        //if al least one true, return normal alert otherwise...guess what uwu
        return hasAdjacentTrues || trueCount is 1 ? normalAlert.Notify() : errorAlert.Notify();
    }
}
