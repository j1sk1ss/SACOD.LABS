namespace Labs;

public class Second_Lab : Math
{
    Math math = new Math();
    public void Main()
    {
        Console.WriteLine("Second lab");
        Console.WriteLine("Type a number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Type a start system less then 11: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (math.CheckSystem(a, b))
        {
            Console.WriteLine("Type a second system less then 11: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int NumInTen = 0;
            if (b != 10) NumInTen = math.ConvertToTen(a, b);
            else NumInTen = a;
            Console.WriteLine(NumInTen);
            Console.WriteLine($"There {a} from {b} system in {c} system is: ");
            string NumInSystem = math.ConvertToSystem(NumInTen, c);
            Console.WriteLine(NumInSystem);
        } else Console.WriteLine("This number is not from this system!");
        
    }
}