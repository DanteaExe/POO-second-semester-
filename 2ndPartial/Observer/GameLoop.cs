using Notifiers;

public class GameLoop
{
    private int ListSize { get; set; }
    private readonly PLC plc = new();
    private readonly ErrorAlert errorAlert = new();

    public void Run()
    {
        do
        {
            Clear();
            WriteLine("Enter list size, must be greater than 0:");
            ListSize = int.Parse(ReadLine()!);
        } while (ListSize <= 0);

        while(true)
        {
            var list = plc.GenerateRandElements(new List<bool>(), ListSize);

            plc.PrintElements(list);
            WriteLine(plc.CheckContinuous(list));
            //handle continue generating and close game
        } 
    }
}
