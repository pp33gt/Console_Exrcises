using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{

    class Person
    {
        private int age = 0;
        private string fName = string.Empty;
        private string lName = string.Empty;
        private double height = 0;
        private double weight = 0;

        public int Age { get => age; set => age = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }

        public override string ToString()
        {
            return $"Age:{Age} FName:{FName} LName:{LName} Height:{Height} Weight: {Weight}";
        }
    }
}
