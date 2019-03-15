using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height​, double weight)
        {
            var person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height​;
            person.Weight = weight;
            return person;
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string fname)
        {
            pers.FName = fname;
        }

        public void SetLName(Person pers, string lname)
        {
            pers.LName = lname;
        }

        public void SetHeight​(Person pers, int height​)
        {
            pers.Height​ = height​;
        }

        public void SetWeight(Person pers, int weight)
        {
            pers.Weight = weight;
        }
    }
}
