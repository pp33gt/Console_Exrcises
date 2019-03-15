using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Bird : Animal
    {
        private bool wingSpan = false;
        public bool WingSpan { get => wingSpan; set => wingSpan = value; }

        //8. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i  vilken klass bör vi lägga det?   
        //Svar: i Bird klassen

        public Bird(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string ToString()
        {
            var res = base.ToString();
            return res + $" WingSpan:{WingSpan}";
        }

        public override string Stats()
        {
            return this.ToString();
        }
    }
}
