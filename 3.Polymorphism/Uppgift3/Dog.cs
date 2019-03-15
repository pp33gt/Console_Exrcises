using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Dog : Animal
    {
        private bool highPitchBark = false;
        public bool HighPitchBark { get => highPitchBark; set => highPitchBark = value; }

        public Dog(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string ToString()
        {
            var res = base.ToString();
            return res + $" HighPitchBark:{HighPitchBark}";
        }

        public override string Stats()
        {
            return this.ToString();
        }

        public string UniqMethodForDog()
        {
            return "WOF";
        }

    }
}
