using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sheiyvane ricxvi: ");

            int n = int.Parse(Console.ReadLine());
            int f = 1;

            Console.Write($"{n}! aris ");
            for (int i = 1; i < n + 1; i++)
            {
                if (i == 1)
                {
                    Console.Write($"1");
                }
                else
                {
                    Console.Write($"*{i}");
                }

                f *= i;
            }
            Console.Write($" da udris {f}");
            Console.WriteLine();
        }
    }
}
