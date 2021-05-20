using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr;
            Console.WriteLine("Введите количество входных данных: ");
            uint q = uint.Parse(Console.ReadLine());
            arr = new double[q];
            double value;
            //filling array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите значение для " + i + " ячейки: ");
                value = double.Parse(Console.ReadLine());
                arr[i] = value;
            }

            //showing whole array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            double max = arr[0];
            double min = arr[0];
            //finding max-min values
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
                else if(arr[i]>max){
                    max = arr[i];
                }
            }

            Console.WriteLine("Max value is: " + max);
            Console.WriteLine("Min value is: " + min);


        }
    }
}
