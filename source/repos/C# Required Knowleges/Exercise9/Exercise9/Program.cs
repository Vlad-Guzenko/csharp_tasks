using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    interface IAnimal
    {
        string Describe();
        string Name { get; set; }
    }


    class Dog : IAnimal, IComparable
    {
        string name;

        public string Name { get => name; set => name = Name; }

        public Dog(string name)
        {
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            return this.name.CompareTo((obj as IAnimal).Name);
        }

        public string Describe()
        {
            return $"Hello i'm dog, my name is: {name}";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Fido"));
            dogs.Add(new Dog("Bob"));
            dogs.Add(new Dog("Adam"));
            dogs.Sort();
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Describe());
            }
        }
    }
}
