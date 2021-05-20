using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите лимит: ");
            int lim = int.Parse(Console.ReadLine());
            int sum=0;
            for (int i = 0; i <= lim; i++)
            {
                if (i%2!=0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
