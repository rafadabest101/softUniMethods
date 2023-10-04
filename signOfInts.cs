namespace softUniMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            CheckSign(n);
        }

        static void CheckSign(int number)
        {
            if(number < 0) Console.WriteLine($"The number {number} is negative.");
            else if (number > 0) Console.WriteLine($"The number {number} is positive.");
            else Console.WriteLine($"The number {number} is zero.");
        }
    }
}