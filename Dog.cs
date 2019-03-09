using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Dog:Pet
    {
        public Dog(string type, string name, string owner, double weight) : base(type, name, owner, weight)
        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public Dog(string name, string owner, double weight) : base(name, owner, weight)
        {
  
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public string bark(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("bark!");
            }
            return ("");
        }
    }
}
