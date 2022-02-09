using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool complete = false;
            while (!complete)
            {
                Console.WriteLine("Enter the line number: ");
                int[] result;
                try
                {
                     result = LineOfPascalTriangleForNumber(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrectly entered data");
                    continue;
                }

                foreach (var x in result)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine("\n print another line?");
                if (Console.ReadLine() == "yes") continue;
                else break;
            }
        }

        static int[] LineOfPascalTriangleForNumber(int n)
        {
            int[] result = new int[n + 1];
            result[0] = 1;
            result[result.Length-1] = 1;
            for (int i = 1; i < Math.Ceiling((decimal)result.Length / 2); i++)
            {
                decimal decimalI = i;
                decimal k = (n / decimalI) - ((decimalI - 1) / decimalI);
                result[i] = Convert.ToInt32(result[i - 1] * k);
                result[result.Length - 1 - i] = result[i];
            }
            return result;
        }
    }
}
