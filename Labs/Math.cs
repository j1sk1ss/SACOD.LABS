namespace Labs;
public class Math {
    protected static int ToInt(string? str) {
        try {
            return Convert.ToInt32(str);
        }
        catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    protected static string ConvertToSystem(string number, int endSystem) {
        var num = int.Parse(number);
        var endNumber = "";
            while (num >= endSystem) {
                if ((num % endSystem).ToString().Length > 1) {
                    endNumber += (char)(num % endSystem + 55);
                    num /= endSystem;
                }
                else {
                    endNumber += num % endSystem;
                    num /= endSystem;
                }
            }
        if ((num % endSystem).ToString().Length > 1) {
            endNumber += (char)(num + 55);
        }
        else {
            endNumber += num;
        }
        return Reverse(endNumber);
    }

    protected int ConvertToTen(string number, int startSys) {
        return number.Select(x => x > 55 ? x - 55 : x - '0').Aggregate(0, (total, x) => total*startSys + x);
    }
    protected static bool CheckSystem(string number, int system) {
        var a = number.ToCharArray();
        for (var j = 0; j < a.Length; j++) { 
            if ((a[j] - 55 > system  && a[j] > 55) || (a[j] - '0' > system && a[j] - 55 > system)) return false; 
            if (j == a.Length - 1) return true;
        }
        return false;
    }
    private static string Reverse( string s ) {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    protected static IEnumerable<int> ConvertToNumsArray(int num) {
        var a = num.ToString().ToCharArray();
        var nums = new int[a.Length];
            for (var i = 0; i < a.Length; i++) nums[i] = (int)(a[i] - '0');
        return nums;
    }
}