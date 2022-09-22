namespace Labs;

public class Math
{
    public string ConvertToSystem(int number, int EndSystem)
    {
        int num = number;
        string EndNumber = "";
        while (num >= EndSystem)
        {
            EndNumber += num % EndSystem;
            num /= EndSystem;
        }

        EndNumber += num;
        return Reverse(EndNumber);
    }
    public int ConvertToTen(int number, int StartSys)
    {
        string k = number.ToString();
        char[] num = k.ToCharArray();
        int[] nums = new int[num.Length];
        for (int i = 0; i < num.Length; i++) {nums[i] = (int)(num[i] - '0');}
        int endNum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            endNum += nums[i] * Pow(StartSys, nums.Length - 2 - i);
        }
        return endNum;
    }

    public bool CheckSystem(int number, int system)
    {
        string k = number.ToString();
        char[] a = k.ToCharArray();
        for (int i = 0; i < k.Length; i++)
            if ((int)(a[i] - '0') >= system)
                return false;
        return true;
    }
    public int Pow(int number, int degree)
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
}