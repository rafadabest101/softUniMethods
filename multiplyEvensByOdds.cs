namespace softUniMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            foreach(char digit in Math.Abs(n).ToString())
            {
                int digitValue = digit - '0';
                if(digitValue % 2 == 0) sum += digitValue;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            foreach(char digit in Math.Abs(n).ToString())
            {
                int digitValue = digit - '0';
                if(digitValue % 2 != 0) sum += digitValue;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int n)
        {
            return GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
        }
    }
}