using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Age = 30;
            //person.FName = "hej";
            //person.LName = "svejs";
            //person.Height = 180;
            //person.Weight = 50;
            //Console.WriteLine("Person properties: " + person + "\n\n");
            Console.WriteLine("\n\n\n\nPERSON-exercise");
            PersonHandler personHandler = new PersonHandler();
            var person1 = personHandler.CreatePerson(0, "person1", string.Empty, 0, 0);

            var person2 = personHandler.CreatePerson(0, "person2", string.Empty, 0, 0);

            var person3 = personHandler.CreatePerson(0, "person3", string.Empty, 0, 0);

            Console.WriteLine("personHandler.CreatePerson(): " + person1);
            Console.WriteLine("personHandler.CreatePerson(): " + person2);
            Console.WriteLine("personHandler.CreatePerson(): " + person3);
            Console.WriteLine();

            personHandler.SetAge(person1, 20);
            Console.WriteLine("PersonHandler.SetAge(20) person1: " + person1 + "\n");

            personHandler.SetFName(person2, "p2!!");
            Console.WriteLine("PersonHandler.SetFName(\"p2!!\") person2: " + person2 + "\n");

            personHandler.SetLName(person3, "bar");
            Console.WriteLine("PersonHandler.SetLName(\"bar\") person3:" + person3 + "\n");

            personHandler.SetHeight(person1, 180);
            Console.WriteLine("PersonHandler.Setheight(180) person1:" + person1 + "\n");

            personHandler.SetWeight(person2, 90);
            Console.WriteLine("PersonHandler.Setweight(90) person2:" + person2 + "\n");

            Console.WriteLine("person1: " + person1);
            Console.WriteLine("person2: " + person2);
            Console.WriteLine("person3: " + person3);

            Console.WriteLine("Hit any key to continue");
            Console.ReadKey();

            var animals = new List<Animal>() { /*new Bird("birdy", 1, 8),*/ new Dog("doggy", 2, 7), new Flamingo("flamingy", 3, 6), new Hedgehog("hedgy", 4, 5), new Horse("horsy", 5, 4), new Pelican("pelicany", 6, 3), new Swan("swany", 7, 2), new Worm("wormy", 8, 1)};

            Console.WriteLine("\n\n\n\nANIMALS-exercise");
            foreach (var animal in animals)
            {
                //11.F: Förklara vad det är som händer. 
                //Svar: genom att Stats metoden har överridits så körs subklassens metod.
                Console.WriteLine(animal.Stats());
            }

            Console.WriteLine("Hit any key to continue");
            Console.ReadKey();

            var dogs = new List<Dog>() { new Dog("doggy1", 1, 3)/*, new Horse("horsy", 5, 4)*/ , new Dog("doggy2", 2, 2) , new Dog("doggy3", 3, 1) };
            //8. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans? 
            //Svar: Animal

            animals.AddRange(dogs);
            Console.WriteLine("\n\n\n\nANIMALS filtered on DOGS only");
            foreach (var animal in animals)
            {
                if(animal is Dog)
                {
                    var dog = animal as Dog;
                    Console.WriteLine(animal.Stats() + " what the dog says?:" + dog.UniqMethodForDog());

                    //14. Kommer du åt den metoden från ​Animals listan?
                    //15. F: Varför inte? 
                    //Svar: Nej animal har inte metoden UniqMethodForDog(), den är endast definierad i subklass Dog.
                }
            }

            Console.WriteLine("Hit any key to continue");
            Console.ReadKey();

            /*
            11. F: Varför är polymorfism viktigt att behärska?  
            Svar: Vanligt förekommande i .Net framework.
            12. F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?  
            Svar: Gör det lättare att utöka funktionalitet med tex. en ny typ av klass i en polymorfisk arkitektur
            och där klasserna själva ansvarar för implementationen.
            -mindre risk att introducera buggar i redan befintlig funktionalitet.
            13. F: Vad är det för en skillnad på en Abstrakt klass och ett Interface? 
            Svar: Ett Interface har ingen implementation men abstract class kan ha metoder som redan är imlementerade.
            (En klass kan ärva från flera interface men bara en klass.)
            */
            Console.WriteLine("\n\n\n\nUserError-exercise");
            var userErrors = new List<UserError>() { new NumericInputError(), new TextInputError(), new TextInputError(), new NumericInputError(), new DateTimeInputError(), new BooleanInputError(), new TooLongInputError() };
            foreach (var userError in userErrors)
            {
                Console.WriteLine(userError.UEMessage());
            }

            Console.WriteLine("Hit any key to continue");
            Console.ReadKey();
        }
    }
}
