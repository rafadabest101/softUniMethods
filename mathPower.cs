namespace softUniMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(n, pow));
        }

        static double RaiseToPower(double number, int power)
        {
            double result = 0.0d;
            result = Math.Pow(number, power);
            return result;
        }
    }
}