using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Calculator
    {
        //incapsulation xmpl bcos of access modifiers
        private void Sum(int a = 0, int b = 0)
        {
            Console.WriteLine("Sum: " + (a + b));
        }
        private void Div(double a = 0, double b = 0)
        {
            Console.WriteLine("Div: " + (a / b));
        }
        private void Sub(double a = 0, double b = 0)
        {
            Console.WriteLine("Sub: " + (a - b));
        }
        private void Mult(int a = 0, int b = 0)
        {
            Console.WriteLine("Mult: " + (a * b));
        }

        public void ChooseOperation()
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose operation: ");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Div");
            Console.WriteLine("3 - Sub");
            Console.WriteLine("4 - Mult");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Sum(a,b);
                    break;
                case 2:
                    Div(a,b);
                    break;
                case 3:
                    Sub(a,b);
                    break;
                case 4:
                    Mult(a,b);
                    break;
                default:
                    Console.WriteLine("No cases for: " + ch);
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.ChooseOperation();
        }
    }
}
