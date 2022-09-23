using System.Drawing;

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
            case 1:
                Quest_1();
                break;
            case 2:
                Quest_2();
                break;
            case 3:
                Quest_3();
                break;
            case 4:
                Quest_4();
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

    private void Quest_2()
    {
        int? size = 0;
        int a = 0;
        Console.WriteLine("Type a number, what should be processed: ");
            try
            { 
                a = Convert.ToInt32(Console.ReadLine()); 
                size = _math.ConvertToNumsArray(a).Length;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            int thisNumber = a;
        for (int i = 0; i < size; i++)
        {
            int[] number = _math.ConvertToNumsArray(thisNumber);
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
            try
            {
                value = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
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
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        Console.WriteLine("Square of number is: ");
        Console.WriteLine(_math.Sqrt(number) + "");
    }
}