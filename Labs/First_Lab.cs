using System.Text;

namespace Labs;

public class First_Lab : Math
{
    public void Main()
    {
        Console.WriteLine("Choose type of work: ");
        Console.WriteLine("Convert to binary information (1). ");
        Console.WriteLine("Convert to usually information (2). ");
        int? choose;
            try
            {
                choose = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            switch (choose)
            {
                case 1:
                    Console.WriteLine("Write any information, what should be converted to binary format:");
                    Console.WriteLine(ToBinary(ConvertToByteArray(Console.ReadLine(), Encoding.Default)));
                    break;
                case 2:
                    Console.WriteLine("Write any binary information, what should be converted to default format:");
                    Console.WriteLine(ConvertToString(ConvertToByteArray(Console.ReadLine(), Encoding.Default)));
                    break;
                default:
                    Console.WriteLine("Wrong choose of type of work.");
                    break;
            }
    }

    static byte[] ConvertToByteArray(string str, Encoding encoding)
    {
        return encoding.GetBytes(str);
    }

    static string ToBinary(Byte[] data)
    {
        return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
    } // Don't work converting from binary to default information Bruh.

    string ConvertToString(Byte[] data)
    {
        string word = Encoding.Default.GetString(data);
        return word;
    }
}