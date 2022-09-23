namespace Labs;

public class Math
{
    public int ToInt(string str)
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
                endNumber += num % endSystem;
                num /= endSystem;
            }
        endNumber += num;
        return Reverse(endNumber);
    }
    public int ConvertToTen(int number, int startSys)
    {
        char[] num = number.ToString().ToCharArray();
        var endNum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                endNum += (int)(num[i] - '0') * Pow(startSys, num.Length - 2 - i);
            }
        return endNum;
    }

    public bool CheckSystem(int number, int system)
    {
        char[] a = number.ToString().ToCharArray();
        for (int i = 0; i < a.Length; i++)
            if ((int)(a[i] - '0') >= system)
                return false;
        return true;
    }
    public static int Pow(int number, int degree)
    {
        int num = number;
        if (degree != 0)
        {
           for (int i = 0; i < degree; i++)
               num *= number; 
           return num;
        }
        else return 1;
       
    }
    public static string Reverse( string s )
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public int[] ConvertToNumsArray(int Num)
    {
        char[] a = Num.ToString().ToCharArray();
        int[] nums = new int[a.Length];
            for (int i = 0; i < a.Length; i++) nums[i] = (int)(a[i] - '0');
        return nums;
    }

    public int Sqrt(int number)
    {
        for (int i = 0; i < number; i++)
            if (Pow(i, 1) == number)
            {return i;}
        return number;
    }
}