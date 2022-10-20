using System.Diagnostics;
using System.Globalization;

namespace Labs.LABS;

public class FourthLab
{
    public void Main()
    {
        Console.WriteLine("Second lab");
        Console.WriteLine("Type a problem number: ");
        typeof(FourthLab).GetMethod($"Quest_{Console.ReadLine()}")!.Invoke(new FourthLab(), null);
    }

    private void Quest_1()
    {
        var answer = new string[4, 3];
        var watch = new Stopwatch();
        watch.Start();

        watch.Stop();
        Console.WriteLine(watch.Elapsed.TotalSeconds.ToString(CultureInfo.InvariantCulture));
    }
    private static void CocktailSort(IList<int> inArray)
    {
        int left = 0,
            right = inArray.Count - 1;
        while (left < right)
        {
            for (var i = left; i < right; i++)
            {
                if (inArray[i] > inArray[i + 1])
                    (inArray[i], inArray[i + 1]) = (inArray[i + 1], inArray[i]);
            }
            right--;
            for (var i = right; i > left; i--)
            {
                if (inArray[i - 1] > inArray[i])
                    (inArray[i - 1], inArray[i]) = (inArray[i], inArray[i - 1]);
            }
            left++;
        }
    }

    private static void Swap(ref int a, ref int b) {
        (a, b) = (b, a);
    }

    private static void QSort(int[] array, int firstIndex = 0, int lastIndex = -1)
    {
        while (true)
        {
            if (lastIndex < 0) lastIndex = array.Length - 1;
            if (firstIndex >= lastIndex) return;
            int middleIndex = (lastIndex - firstIndex) / 2 + firstIndex, currentIndex = firstIndex;
            Swap(ref array[firstIndex], ref array[middleIndex]);
            for (var i = firstIndex + 1; i <= lastIndex; ++i)
            {
                if (array[i] <= array[firstIndex])
                {
                    Swap(ref array[++currentIndex], ref array[i]);
                }
            }

            Swap(ref array[firstIndex], ref array[currentIndex]);
            QSort(array, firstIndex, currentIndex - 1);
            firstIndex = currentIndex + 1;
        }
    }
}