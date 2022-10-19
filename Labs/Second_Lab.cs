namespace Labs;

public class SecondLab : Math
{
    public void Main()
    {
        Console.WriteLine("Second lab");
        Console.WriteLine("Type a problem number: ");
        typeof(SecondLab).GetMethod($"Quest_{Console.ReadLine()}")!.Invoke(new SecondLab(), null);
    }

    public void Quest_1()
    {
        Console.WriteLine("Type a number, what should be converted: ");
        var a1 = ToInt(Console.ReadLine());
            Console.WriteLine("Type a start system: ");
            var b1 = ToInt(Console.ReadLine());
                Console.WriteLine("Type a second system: ");
                var c1 = ToInt(Console.ReadLine());
        if (CheckSystem(a1, b1))
        {
            var numInTen = b1 != 10 ? ConvertToTen(a1.ToString(), b1) : a1;
            Console.WriteLine(numInTen);
            Console.WriteLine($"There {a1} from {b1} system in {c1} system is: ");
            var numInSystem = ConvertToSystem(numInTen, c1);
            Console.WriteLine(numInSystem);
        } else Console.WriteLine("This number is not from this system!");
    }

    private void Quest_2()
    {
        int? size = 0;
        int a = 0;
        Console.WriteLine("Type a number, what should be processed: ");
        a = ToInt(Console.ReadLine());
            try
            {
                size = ConvertToNumsArray(a).Length;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            int thisNumber = a;
        for (int i = 0; i < size; i++)
        {
            int[] number = ConvertToNumsArray(thisNumber);
            int? thisSize = number.Length;
            if (thisSize <= 1) break;
            thisNumber = 0;
                for (int j = 0; j < thisSize; j++) thisNumber += number[j];
        }
        Console.WriteLine("The answer is: ");
        Console.WriteLine(thisNumber);
    }

    private void Quest_3()
    {
        Console.WriteLine("Type a value, what should be represented by RU banknotes between 50 and 10000: ");
        int value = 0;
        int[] banknotes = {5000, 2000, 1000, 500, 200, 100, 50, 10};
        value = ToInt(Console.ReadLine());
            Console.WriteLine("Banknotes: ");
            while (value > 10)
            {
                for (int i = 0; i < banknotes.Length; i++)
                    if (value - banknotes[i] >= 0)
                    {
                        Console.WriteLine(banknotes[i]);
                        value -= banknotes[i];
                        i--;
                    }
            }
            Console.WriteLine("Remainder: " + value);
    }

    private void Quest_4()
    {
        int number = 0;
        Console.WriteLine("Write a number, what square should be find: ");
        number = ToInt(Console.ReadLine());
        Console.WriteLine("Square of number is: ");
        Console.WriteLine(System.Math.Sqrt(number) + "");
    }
}