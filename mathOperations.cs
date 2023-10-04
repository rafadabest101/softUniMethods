namespace softUniMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculator(a, oper, b));
        }

        static double Calculator(int a, string oper, int b)
        {
            double result = 0.0d;

            switch(oper)
            {
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }

            return result;
        }
    }
}