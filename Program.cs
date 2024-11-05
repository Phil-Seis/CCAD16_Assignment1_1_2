namespace CCAD16_Assignment1_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a simple console application and declare basic datatypes like int, float, decimal, double and print their min and max values.
            int x = 5;
            float y = 44;
            decimal z = 33.4m;
            double a = 16.55;

            Console.WriteLine(Math.Max(x, z));
            Console.WriteLine(Math.Min(y, a));
        }
    }
}
