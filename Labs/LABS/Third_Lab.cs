namespace Labs.LABS;

public class ThirdLab
{
    public void Main()
    {
        Console.WriteLine("Second lab");
        Console.WriteLine("Type a problem number: ");
        typeof(ThirdLab).GetMethod($"Quest_{Console.ReadLine()}")!.Invoke(new ThirdLab(), null);
    }

    public void Quest_1()
    {
        Console.WriteLine(TrivialPow(2,2));
    }
    private static double TrivialPow(double number, double degree) // log n
    {
        var f = 1.0;
        var k = 0.0;
        while (k < degree)
        {
            f = f * number;
            k++;
        }
        return f;
    }
}