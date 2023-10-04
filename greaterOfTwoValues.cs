namespace softUniMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            switch(dataType)
            {
                case "int":
                    int n1 = int.Parse(Console.ReadLine());
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxInt(n1, n2));
                    break;
                case "char":
                    char ch1 = char.Parse(Console.ReadLine());
                    char ch2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxChar(ch1, ch2));
                    break;
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Console.WriteLine(GetMaxString(str1, str2));
                    break;
                default:
                    Console.WriteLine("Invalid data type!");
                    break;
            }
        }

        static int GetMaxInt(int n1, int n2)
        {
            if(n1 <= n2) return n2;
            else return n1;
        }
        static char GetMaxChar(char ch1, char ch2)
        {
            if(ch1 <= ch2) return ch2;
            else return ch1;
        }
        static string GetMaxString(string str1, string str2)
        {
            if(str1[0] <= str2[1]) return str2;
            else return str1;
        }
    }
}