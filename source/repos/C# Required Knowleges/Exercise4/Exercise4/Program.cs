using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество шагов: ");
            int M = int.Parse(Console.ReadLine());

            for (int i = M-1; i >= 0; i--)
            {
                N--;
                Console.Write(N + " ");
            }
        }
    }
}
