﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

        public Pet(string type, string name, string owner, double weight)
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public Pet(string name, string owner, double weight)
        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public string getTag()
        {
            return String.Format("If lost, call {0}", owner);
        }
    }
}
