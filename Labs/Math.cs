namespace Labs;

public class Math
{
    protected static int ToInt(string? str)
    {
        try
        {
            return Convert.ToInt32(str);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
  
    }
    public string ConvertToSystem(int number, int endSystem)
    {
        var num = number;
        var endNumber = "";
            while (num >= endSystem)
            {
                if ((num % endSystem).ToString().Length > 1)
                {
                    endNumber += (char)(num % endSystem + 55);
                    num /= endSystem;
                }
                else
                {
                    endNumber += num % endSystem;
                    num /= endSystem;
                }
            }
        if ((num % endSystem).ToString().Length > 1)
        {
            endNumber += (char)(num + 55);
        }
        else
        {
            endNumber += num;
        }
        return Reverse(endNumber);
    }
    public int ConvertToTen(string number, int startSys)
    {
        var num = number.ToCharArray();
        return num.Select((t, i) => (t > 64) switch
            {
                true => (t - 55) * (int)System.Math.Pow(startSys, num.Length - 1 - i),
                _ => (t - 48) * (int)System.Math.Pow(startSys, num.Length - 1 - i)
            })
            .Sum();
    }
    protected static bool CheckSystem(int number, int system)
    {
        var a = number.ToString().ToCharArray();
        return a.All(t => (int)(t - '0') < system);
    }
    private static string Reverse( string s )
    {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    protected static int[] ConvertToNumsArray(int num)
    {
        var a = num.ToString().ToCharArray();
        var nums = new int[a.Length];
            for (var i = 0; i < a.Length; i++) nums[i] = (int)(a[i] - '0');
        return nums;
    }
}