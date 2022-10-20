using Labs.LABS;

namespace Labs
{
    class MainClass
    {
        public static void Main()
        {
            var labs = new Dictionary<int, Action>
            {
                {1,new FirstLab().Main},
                {2,new SecondLab().Main},
                {3,new ThirdLab().Main},
                {4,new FourthLab().Main}
            };
            Console.WriteLine("Choose lab: ");
            labs[int.Parse(Console.ReadLine()!)]();
        }
     }
}