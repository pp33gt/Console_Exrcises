using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Horse: Animal
    {
        private bool isRodeoHorse = false;
        public bool IsRodeoHorse { get => isRodeoHorse; set => isRodeoHorse = value; }

        public Horse(string name, double weight, int age): base(name, weight, age)
        {
        }

        public override string ToString()
        {
            var res = base.ToString();
            return res + $" IsRodeoHorse:{IsRodeoHorse}";
        }

        public override string Stats()
        {
            return this.ToString();
        }
    }
}
