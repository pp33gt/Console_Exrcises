using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Hedgehog : Animal
    {
        private int nrOfSpikes = 0;
        public int NrOfSpikes { get => nrOfSpikes; set => nrOfSpikes = value; }

        public Hedgehog(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string ToString()
        {
            var res = base.ToString();
            return res + $" NrOfSpikes:{NrOfSpikes}";
        }

        public override string Stats()
        {
            return this.ToString();
        }
    }
}
