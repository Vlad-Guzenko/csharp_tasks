using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Введите 10 чисел...");
            System.Threading.Thread.Sleep(800);
            Console.Clear();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите число для "+ i +" элемента массива: ");
                string n = Console.ReadLine();
                
                arr[i] = d;
                Console.Clear();
            }

            //Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            
        }
    }
}
