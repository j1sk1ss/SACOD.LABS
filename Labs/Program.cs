using System;
using System.IO;
namespace Labs
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Choose lab: ");
            int? k = 0;
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            switch (k)
            {
                case (1):
                    First_Lab firstLab = new First_Lab();
                    firstLab.Main();
                    break;
                case (2):
                    Second_Lab secondLab = new Second_Lab();
                    secondLab.Main();
                    break;
                default:
                    Console.WriteLine("Lab not exist.");
                    break;
            }
        }
     }
}