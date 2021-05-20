using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static int CountDigit(int a, int b)
        {
            if (a==0)
            {
                return 0;
            }
            else
            {
                return CountDigit(a / 10, b) + (Math.Abs(a) % 10 == b ? 1 : 0);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number to search:");
            int search = int.Parse(Console.ReadLine());
            Console.WriteLine(CountDigit(num, search));
        }
    }
}
