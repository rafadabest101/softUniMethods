namespace softUniMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintPyramids(n);
        }

        static void PrintPyramids(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                PrintSingleLine(1, i);
            }
            for(int i = n - 1; i >= 1; i--)
            {
                PrintSingleLine(1, i);
            }
        }

        static void PrintSingleLine(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}