using System.Text;
using static System.IO.FileAccess;
using static System.IO.FileMode;
using System.IO;
using System.Net.Mime;

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
                    Console.WriteLine(ConvertFromBytes(ReadBytesFromFile(@"D:\загрузки")));
                    break;
                default:
                    Console.WriteLine("Wrong choose of type of work.");
                    break;
            }
    }

    static byte[] ConvertToByteArray(string? str, Encoding encoding)
    {
        return encoding.GetBytes(str);
    }

    static string ToBinary(Byte[] data)
    {
        try
        {
            return string.Join("", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }
        catch (Exception e)
        {
            return e.ToString();
            throw;
        }
    } // Don't work converting from binary to default information Bruh.

    string ConvertFromBytes(Byte[] data)
    {
        string result = System.Text.Encoding.UTF8.GetString(data);
        return result;
    }
    byte[] ReadBytesFromFile(string path)
    {
        byte[] chunk;
            try
            {
                using (var filestream = new FileStream(path + @"/Test.txt", Open, Read))
                {
                    using (BinaryReader binaryReader = new BinaryReader(filestream, Encoding.Default))
                    {
                        chunk = binaryReader.ReadBytes(1024);
                        while(chunk.Length > 0)
                        {
                            DumpBytes(chunk, chunk.Length);
                            chunk = binaryReader.ReadBytes(1024);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        return chunk;
    }
    public static void DumpBytes(byte[] bdata, int len)
    {
        int i;
        int j = 0;
        char dchar;
        StringBuilder dumptext = new StringBuilder("       ", 16 * 4 + 8);
        for (i = 0; i < len; i++)
        {
            dumptext.Insert(j * 3, String.Format("{0:X2} ", (int)bdata[i]));
            dchar = (char)bdata[i];
            if (Char.IsWhiteSpace(dchar) || Char.IsControl(dchar))
            {
                dchar = '.';
            }
            dumptext.Append(dchar);
            j++;
            if (j == 16)
            {
                Console.WriteLine(dumptext);
                dumptext.Length = 0;
                dumptext.Append("        ");
                j = 0;
            }
        }
        if (j > 0)
        {
            for (i = j; i < 16; i++)
            {
                dumptext.Insert(j * 3, "   ");
            }
            Console.WriteLine(dumptext);
        }
    }
}