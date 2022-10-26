namespace Labs.LABS;
public class SecondLab : Math
{
    public void Main() {
        Console.WriteLine("Second lab");
        Console.WriteLine("Type a problem number: ");
        typeof(SecondLab).GetMethod($"Quest_{Console.ReadLine()}")!.Invoke(new SecondLab(), null);
    }

    public void Quest_1() {
        Console.WriteLine("Type a number, what should be converted: ");
        var a1 = Console.ReadLine();
        Console.WriteLine("Type a start system: ");
        var b1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Type a second system: ");
        var c1 = ToInt(Console.ReadLine());
        if (a1 != null && CheckSystem(a1, b1)) {
            var numInTen = 0;
            numInTen = b1 != 10 ? ConvertToTen(a1, b1) : int.Parse(a1);
            Console.WriteLine(numInTen);
            Console.WriteLine($"There {a1} from {b1} system in {c1} system is: ");
            var numInSystem = ConvertToSystem($"{numInTen}", c1);
            Console.WriteLine(numInSystem);
        }
        else Console.WriteLine("This number is not from this system!");
    }

    public void Quest_2() {
        var a = 0;
        Console.WriteLine("Type a number, what should be processed: ");
        a = ToInt(Console.ReadLine());
        var thisNumber = a;
        while(thisNumber > 9) {
            thisNumber = ConvertToNumsArray(thisNumber).Sum();
        }
        Console.WriteLine($"The answer is: {thisNumber}");
    }

    public void Quest_3() {
        Console.WriteLine("Type a value, what should be represented by RU banknotes between 50 and 10000: ");
        var value = 0;
        int[] banknotes = { 5000, 2000, 1000, 500, 200, 100, 50, 10 };
        var bnk = new int[banknotes.Length];
        value = ToInt(Console.ReadLine());
        Console.WriteLine("Banknotes: ");
        for (var i = 0; i < banknotes.Length; i++)
            while (value - banknotes[i] >= 0) {
                bnk[i] += banknotes[i];
                value -= banknotes[i];
            }
        for (var i = 0; i < banknotes.Length; i++)
            if (bnk[i] != 0)
                Console.WriteLine($"U will need: {bnk[i] / banknotes[i]}x {banknotes[i]}");
        Console.WriteLine($"Remainder: {value}");
    }

    public void Quest_4() // Проводиит деление, если находит период - выводит его по вем правилам
    {
        Console.WriteLine("Write a numbers, what should be divided: ");
        var first = int.Parse(Console.ReadLine()!);
        var second = int.Parse(Console.ReadLine()!);
            
    }
}