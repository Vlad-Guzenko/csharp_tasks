using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    interface IAnimal
    {
        void Walk();
        void Brain();
        void TalkEnglish();
    }

    class InterfaceTest : IAnimal
    {
        public string _name = "arpit";
        public void Walk()
        {
            Console.WriteLine("Animals can walk!\n");
        }
        public void Brain()
        {
            Console.WriteLine("Animals also have a brain\n");
        }
        public void TalkEnglish()
        {
            Console.WriteLine("Animals for some reason can't talk in english!\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InterfaceTest test = new InterfaceTest();
            test.Brain();
            test.TalkEnglish();
            test.Walk();
        }
    }
}
