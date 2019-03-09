using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // For the Pet class
            Pet pet1 = new Pet("dog", "Shadow", "Jose", 42.6);
            Console.WriteLine("Name: " + pet1.name);
            Console.WriteLine("Weight: " + pet1.weight);
            Console.WriteLine(pet1.getTag());

            Console.WriteLine("");

            //For the Dog class
            Dog dog1 = new Dog("Daisy", "Kent", 23.4);

            Console.WriteLine("Name: " + dog1.name);
            Console.WriteLine("Weight: " + dog1.weight);
            Console.WriteLine(dog1.getTag());
            Console.WriteLine(dog1.bark(4));

            Console.WriteLine("");

            //For the Cat class
            Cat cat1 = new Cat("Simba", "Maria", 5.2);

            Console.WriteLine("Name: " + cat1.name);
            Console.WriteLine("Weight: " + cat1.weight);
            Console.WriteLine(cat1.getTag());
            Console.WriteLine(cat1.meow(3));

            Console.WriteLine("");

            Console.Write("Press any key to continue...");

            Console.ReadLine();
        }
    }
}
