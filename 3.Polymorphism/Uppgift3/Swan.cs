using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Swan : Bird
    {
        private bool canDriveOffDog = false;
        public bool CanDriveOffDog { get => canDriveOffDog; set => canDriveOffDog = value; }

        public Swan(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string ToString()
        {
            var res = base.ToString();
            return res + $" CanDriveOffDog:{CanDriveOffDog}";
        }

        public override string Stats()
        {
            return this.ToString();
        }
    }
}
