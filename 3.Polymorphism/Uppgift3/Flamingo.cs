using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Flamingo : Bird
    {
        private bool canKickCan = false;
        public bool CanKickCan { get => canKickCan; set => canKickCan = value; }

        public Flamingo(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string ToString()
        {
            var res = base.ToString();
            return res + $" CanKickCan:{CanKickCan}";
        }

        public override string Stats()
        {
            return this.ToString();
        }
    }
}
