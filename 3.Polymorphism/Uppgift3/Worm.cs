using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Worm : Animal
    {
        private bool isPoisonous = false;
        public bool IsPoisonous { get => isPoisonous; set => isPoisonous = value; }

        public Worm(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string ToString()
        {
            var res = base.ToString();
            return res + $" IsPoisonous:{IsPoisonous}";
        }

        public override string Stats()
        {
            return this.ToString();
        }
    }
}
