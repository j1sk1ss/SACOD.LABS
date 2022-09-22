namespace Labs;

public class Second_Lab : Math
{
    readonly Math _math = new Math();
    public void Main()
    {
        Console.WriteLine("Second lab");
        Console.WriteLine("Type a problem number: ");
        int? quest;
            try
            {
                quest = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        switch (quest)
        {
            case (1):
                Quest_1();
                break;
            default:
                Console.WriteLine("Quest not exist.");
                break;
        }
    }

    private void Quest_1()
    {
        int a1, b1, c1;
        Console.WriteLine("Type a number, what should be converted: ");
        string? a = Console.ReadLine();
            Console.WriteLine("Type a start system less then 11: ");
            string? b = Console.ReadLine();
                Console.WriteLine("Type a second system less then 11: ");
                string? c = Console.ReadLine();
            try
            {
                a1 = Convert.ToInt32(a);
                b1 = Convert.ToInt32(b); 
                c1 = Convert.ToInt32(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        if (_math.CheckSystem(a1, b1))
        {
            var numInTen = 0;
            numInTen = b1 != 10 ? _math.ConvertToTen(a1, b1) : a1;
            Console.WriteLine(numInTen);
            Console.WriteLine($"There {a1} from {b1} system in {c} system is: ");
            var numInSystem = _math.ConvertToSystem(numInTen, c1);
            Console.WriteLine(numInSystem);
        } else Console.WriteLine("This number is not from this system!");
    }
}