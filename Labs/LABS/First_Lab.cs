using System.Text;

namespace Labs.LABS;
public class FirstLab : Math
{
    public void Main()
    {
        Console.WriteLine("Choose type of work: ");
        Console.WriteLine("Convert to binary information (1). ");
        Console.WriteLine("Convert to usually information (2). ");
        switch (int.Parse(Console.ReadLine()!))
        {
            case 1:
                Console.WriteLine("Write any information, what should be converted to binary format:");
                Console.WriteLine(ToBinary(ConvertToByteArray(Console.ReadLine(), Encoding.UTF8)));
                break;
            case 2:
                Console.WriteLine("Write any binary information, what should be converted to default format:");
                Console.WriteLine(Encoding.UTF8.GetString(ToByteArray(Console.ReadLine()!)));
                break;
            default:
                Console.WriteLine("Wrong choose of type of work.");
                break;
        }
    }
    private static IEnumerable<byte> ConvertToByteArray(string? str, Encoding encoding)
    {
        return (str != null ? encoding.GetBytes(str) : null)!;
    }

    private static string ToBinary(IEnumerable<byte> data)
    {
        try
        {
            return string.Join("", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }
        catch (Exception e)
        {
            return e.ToString();
        }
    }

    private static byte[] ToByteArray(string binaryString)
    {
        var numOfBytes = binaryString.Length / 8;
        var bytes = new byte[numOfBytes];
        for (var i = 0; i < numOfBytes; i++)
        {
            var oneBinaryByte = binaryString.Substring(8 * i, 8);
            bytes[i] = Convert.ToByte(oneBinaryByte, 2);
        }
        return bytes;
    }
}