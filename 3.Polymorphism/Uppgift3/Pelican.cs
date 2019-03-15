using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Pelican : Bird
    {
        private bool canEatTuna = false;
        public bool CanEatTuna { get => canEatTuna; set => canEatTuna = value; }

        public Pelican(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string ToString()
        {
            var res = base.ToString();
            return res + $" CanEatTuna:{CanEatTuna}";
        }

        public override string Stats()
        {
            return this.ToString();
        }
    }
}
