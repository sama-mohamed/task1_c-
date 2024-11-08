namespace task1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to our carpet cleaning service");
            Console.WriteLine("How many small carpets would you like to clean?");
            int small_carpets = int.Parse(Console.ReadLine());
            Console.WriteLine("How many large carpets would you like to clean?");
            int large_carpets = int.Parse(Console.ReadLine());
            Console.WriteLine("Please check our prices \n cleaning the small carpet costs: 25$ \n cleaning the large carpet costs: 35$");
            int cost = (small_carpets * 25) + (large_carpets * 35);
            Console.WriteLine($"Cost :{cost}");
            double tax = cost * .06;
            Console.WriteLine($"Tax :{tax}");
            Console.WriteLine("==============================");
            double total = cost + tax;
            Console.WriteLine($"Total estimate: {total}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}





