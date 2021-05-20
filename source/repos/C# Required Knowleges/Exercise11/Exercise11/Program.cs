using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Guy
    {
        public string name;
        public int age;
        public void PrintData()
        {
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Guy g = new Guy();
            Console.WriteLine("What is your name?: ");
            g.name = Console.ReadLine();
            Console.WriteLine("How old are you?: ");
            g.age = int.Parse(Console.ReadLine());
            g.PrintData();
        }
    }
}
