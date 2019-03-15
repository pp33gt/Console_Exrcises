using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Animal
    {
        private string name = string.Empty;

        private double weight = 0;

        private int age = 0;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Age { get => age; set => age = value; }

        //9. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då? 
        //Svar: i Animal klassen.

        protected Animal(string name, double weight, int age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Name:{Name} Weight:{Weight} Age:{Age}";
        }
       

        public virtual string Stats()
        {
            return this.ToString();
        }
    }
}
