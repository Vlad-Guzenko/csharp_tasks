using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type something...");
            string str = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Your txt: \n" + str);


            string[] words = str.Split(' ');
            string strNew = "";
            strNew = string.Join(" ", words.Reverse());

            Console.WriteLine("------------------------");
            Console.WriteLine("Result: \n" + strNew);
        }
    }
}
