namespace softUniMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            PrintOrderResult(product, n);
        }

        static void PrintOrderResult(string product, int n)
        {
            switch(product)
            {
                case "coffee":
                    Console.WriteLine($"{1.50 * n:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{1.00 * n:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{1.40 * n:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{2.00 * n:f2}");
                    break;
                default:
                    Console.WriteLine("Inavlid product!");
                    break;
            }
        }
    }
}