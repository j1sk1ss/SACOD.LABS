namespace Labs
{
    class MainClass
    {
        public static void Main()
        {
            var labs = new Dictionary<int, Action>
            {
                {1,new First_Lab().Main},
                {2,new SecondLab().Main}
            };
            Console.WriteLine("Choose lab: ");
            labs[int.Parse(Console.ReadLine()!)]();
        }
     }
}