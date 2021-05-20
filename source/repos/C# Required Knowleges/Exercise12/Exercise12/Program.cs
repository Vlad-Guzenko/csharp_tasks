using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{

    interface IGuy
    {
        string Name { get; set; }
        int Age { get; set; }
    }

    class Guy:IGuy, IComparable
    {
        public string _name;
        public int _age;

        public string Name { get => _name; set => _name = Name; }
        public int Age { get => _age; set => _age = Age; }

        public Guy(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public int CompareTo(object obj)
        {
            return this._age.CompareTo((obj as IGuy).Age);
        }

        public void PrintData()
        {
            Console.WriteLine($"Guy name is: {_name}");
            Console.WriteLine($"Guy age is: {_age}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Guy> guys = new List<Guy>();

            guys.Add(new Guy("Max" , 23));
            guys.Add(new Guy("Lewis" , 36));
            guys.Add(new Guy("Vallteri" , 31));
            guys.Add(new Guy("Charles" , 23));
            guys.Add(new Guy("Sebastian" , 33));
            guys.Add(new Guy("Lando" , 21));
            guys.Add(new Guy("Fernando" , 39));
            guys.Add(new Guy("Pierre" , 25));
            guys.Add(new Guy("Kimi" , 41));
            guys.Add(new Guy("Antonio" , 27));

            ////////////////////////////
            //All data

            /*foreach (var guy in guys)
            {
                guy.PrintData();
            }*/


            //////////////////////////////
            //Min age
            /*var min = guys.Min(r => r.Age);
            Guy a = guys.First(y => y.Age == min);
            a.PrintData();*/

            //////////////////////////////
            //inside range
            int min = 15;
            int max = 25;

            /*foreach (var item in guys)
            {
                if (item.Age >= 15 && item.Age <=25)
                {
                    item.PrintData();
                }
            }*/

            ////////////////////////
            //outside range
            /*foreach (var item in guys)
            {
                if (item.Age <= 15 || item.Age >= 25)
                {
                    item.PrintData();
                }
            }*/

            ////////////////////////
            //starts on "C"

            /*foreach (var item in guys)
            {
                if (item.Name.StartsWith("C"))
                {
                    item.PrintData();
                }
            }*/

            ////////////////////////
            //contains "c"

            /*foreach (var item in guys)
            {
                if (item.Name.Contains("C") || item.Name.Contains("c"))
                {
                    item.PrintData();
                }
            }*/

            /////////////////////////
            //sort list by age

            /*guys.Sort();
            foreach (var item in guys)
            {
                item.PrintData();
            }*/

            var ageGroups = from guy in guys
                            group guy by guy._age;

            foreach (IGrouping<int, Guy> g in ageGroups)
            {
                Console.WriteLine("=============");
                Console.WriteLine("Age: " + g.Key);
                foreach (var item in g)
                {
                    item.PrintData();
                }
                Console.WriteLine("=============");
            }

            //show every guy +
            //the youngest   +
            //ages btwin 15 - 25 years +
            //outside 15 - 25 years +
            //name starts with 'c' +
            //name includes 'c' +
            //sort list by age +
            //group list by ages +
        }
    }
}
