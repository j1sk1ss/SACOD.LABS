// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
namespace Labs
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Choose lab: ");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case (2):
                    Second_Lab secondLab = new Second_Lab();
                    secondLab.Main();
                    break;
                default:
                    Console.WriteLine("Lab not exist");
                    break;
            }
        }
     }
}