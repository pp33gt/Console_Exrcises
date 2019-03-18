using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            /*
            1.​​​Hur​ ​fungerar​ ​​stacken och​ ​​heapen?​ ​Förklara​ ​gärna​ ​med​ ​exempel​ ​eller​ ​skiss​ ​på​ ​dess  grundläggande​ ​funktion
            SVAR: Stacken: Det som läggs på stacken hamnar i en ordning
            Det som läggs där först hamnar underst
            Det som läggs till vartefter läggs ovanpå varandra.
            Det som läggs till senast kan nås direkt.
            Det som ligger längre ner i stacken kan man inte nå förrän man flyttat bort de som ligger ovanpå.
            Behöver inte Garbage collection eftersom det sköts av sig självt.
            Värdetyper lagras här.

            Heapen: Allt som ligger på heapen är nåbart direkt om man har adressen dit.
            Behöver Garbage collection eftersom det är Objekt
            som lagras här. Vartefter som .Net program körs
            så kan Objekt (referenstyper) bli inaktuella dvs.
            ingen referens pekar på objecktet längre.
            När dom upptäcks av Garbage collectorn så rensas dom.

            2.​​Vad​ ​är​ ​​Value Types repsektive​ ​​Reference Types och​ ​vad​ ​skiljer​ ​dem​ ​åt?  
            Svar: Value Types lagras på Stacken.(om dom inte är deklarerade i ett objekt)
            ReferensTyper lagras alltid på Heapen.

            3.Följande​ ​metoder​ ​(​se bild nedan)​ ​genererar​ ​olika​ ​svar.​ ​Den​ ​första​ ​returnerar​ ​3,​ ​den  andra​ ​returnerar​ ​4,​ ​varför?  


            ReturnValue();
            int är värdetyp, x tilldelas värdet 3 och behåller det genom hela metodanropet.
            y tilldelas tillfälligt samma värde som x (kopieras)
            sedan får y ett nytt värde 4.
            


            ReturnValue2();
            MyInt är referenstyp
            x pekar på objektet MyInt som innehåller x = 3.
            y kopierar referensen till x och sätter om MyValue från 3 till 4.
            */

            //var res = RecursiveEven(1);
            //var res = RecursiveEven(4);

            //var fibo0 = RecursiveFibonacci(0); //0
            //var fibo1 = RecursiveFibonacci(1); //1
            //var fibo2 = RecursiveFibonacci(2);   //1
            //var fibo3 = RecursiveFibonacci(3);   //2
            //var fibo4 = RecursiveFibonacci(4);   //3
            //var fib5 = RecursiveFibonacci(5);    //5
            //var fib6 = RecursiveFibonacci(6);
            //var fib7 = RecursiveFibonacci(7);
            //var fib8 = RecursiveFibonacci(8);
            //var fib9 = RecursiveFibonacci(9);
            //var fib10 = RecursiveFibonacci(10);
            //var fib11 = RecursiveFibonacci(11);
            //var fib12 = RecursiveFibonacci(12);
            //var fib13 = RecursiveFibonacci(13);
            //var fib14 = RecursiveFibonacci(14);

            var fibon0 = InterativeFibonacci(0);   //0
            var fibon1 = InterativeFibonacci(1);   //1
            var fibon2 = InterativeFibonacci(2);   //1
            var fibon3 = InterativeFibonacci(3);   //2
            var fibon4 = InterativeFibonacci(4);   //3
            var fibon5 = InterativeFibonacci(5);   //5
            var fibon13 = InterativeFibonacci(13); //233

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }



        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            List<string> theList = new List<string>();
            var exit = false;
            while (!exit)
            {
                var capacity = theList.Capacity;
                var count = theList.Count;
                Console.WriteLine($"theList.Capacity:{capacity} theList.Count: {count}");

                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    case 'q':
                    case 'Q':
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
            /*
            2.När​ ​ökar​ ​listans​ ​kapacitet?​ ​(Alltså​ ​den​ ​underliggande​ ​arrayens​ ​storlek)  
            3.Med​ ​hur​ ​mycket​ ​ökar​ ​kapaciteten?  
            Svar: när 5:e elementet ska läggas till ökas underliggande arrayen med 4

            4.Varför​ ​ökar​ ​inte​ ​listans​ ​kapacitet​ ​i​ ​samma​ ​takt​ ​som​ ​element​ ​läggs​ ​till?  
            Svara: Det kostar prestanda att utöka Arrayen för varje element.
            5.​​Minskar​ ​kapaciteten​ ​när​ ​element​ ​tas​ ​bort​ ​ur​ ​listan?  
            Svar: Nej
            6.​​När​ ​är​ ​det​ ​då​ ​fördelaktigt​ ​att​ ​använda​ ​en​ ​egendefinierad​ ​​array istället​ ​för​ ​en​ ​lista?  
            Svar: när man vet hur många element som behöver lagras från början.
             */
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
                 ​​Simulera​ ​följande​ ​kö​ ​på​ ​papper:  
                a.​​ICA​ ​öppnar​ ​och​ ​kön​ ​till​ ​kassan​ ​är​ ​tom                     0
                b.​​Kalle​ ​ställer​ ​sig​ ​i​ ​kön                                   Queue:Kalle
                c.​​Greta​ ​ställer​ ​sig​ ​i​ ​kön                                   Queue:Kalle<-Greta
                d.​​Kalle​ ​blir​ ​expedierad​ ​och​ ​lämnar​ ​kön                      Queue:Greta
                e.​​Stina​ ​ställer​ ​sig​ ​i​ ​kön                                   Queue:Greta<-Stina
                f.Greta​ ​blir​ ​expedierad​ ​och​ ​lämnar​ ​kön                      Queue:Stina
                g.​​Olle​ ​ställer​ ​sig​ ​i​ ​kön                                    Queue:Stina<-Olle
                h.​​… 
             */

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            var queue = new Queue();

            var exit = false;
            while (!exit)
            {
                Console.WriteLine($"Queue:{queue}");

                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        queue.AddToQueue(value);
                        break;
                    case '-':
                        queue.DeQueue();
                        break;
                    case 'q':
                    case 'Q':
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {

            /*
                ​​Simulera​ ​följande​ ​kö​ ​på​ ​papper:  
               a.​​ICA​ ​öppnar​ ​och​ ​kön​ ​till​ ​kassan​ ​är​ ​tom                     0
               b.​​Kalle​ ​ställer​ ​sig​ ​i​ ​kön                                   Stack:Kalle
               c.​​Greta​ ​ställer​ ​sig​ ​i​ ​kön                                   Stack:Greta->Kalle
               d.​​Kalle​ ​blir​ ​expedierad​ ​och​ ​lämnar​ ​kön                      Stack:Kalle (Pop tar bort Greta)
               e.​​Stina​ ​ställer​ ​sig​ ​i​ ​kön                                   Stack:Stina->Kalle 
               f.Greta​ ​blir​ ​expedierad​ ​och​ ​lämnar​ ​kön                      Stack:Kalle (Pop tar bort Stina)
               g.​​Olle​ ​ställer​ ​sig​ ​i​ ​kön                                    Stack:Olle-> Kalle
               h.​​… 
            */

            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            var stack = new Stack();

            var exit = false;
            while (!exit)
            {
                Console.WriteLine($"Queue:{stack}");

                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        stack.AddToQueue(value);
                        break;
                    case '-':
                        stack.DeQueue();
                        break;
                    case 'q':
                    case 'Q':
                        exit = true;
                        break;
                    default:
                        var reverseTxt = stack.ReverseText(input);
                        Console.WriteLine(reverseTxt);
                        break;
                }
            }
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]

             filtrera ut alla parenteser:
             om Count paranteser är udda -> Not Wellformed
             om Jämnt splitta parenteser på hälften
             kolla första hälft att det är öppna.
             kolla andra hälft om det är stängda. Isåfall wellformed.

             List<int>​ ​lista​ ​=​ ​new​ ​List<int>(){2,​ ​3,​ ​4};
             "()" --> 
             räkna öppna: "(": 
             räkna stängda: ")" 
             count öppna == stängda -> wellformed

             List<int>​ ​lista​ ​=​ ​new​ ​List<int>)(){2,​ ​3,​ ​4};”
             ")()"
             
             count öppna != stängda -> Not wellformed
             */

            Console.WriteLine("Mata in en sträng");
            var userInput = Console.ReadLine();

            var wellformedValidator = new WellformedValidator();
            var wellFormed = wellformedValidator.IsWellFormedParentesises(userInput);
            var outputRes = $"Strängens parenteser är väl formaterad! \n\n\n";
            if (!wellFormed)
            {
                outputRes = $"Strängens parenteser är inte väl formaterad! \n\n\n";
            }
            Console.WriteLine(outputRes);
        }

        static int ReturnValue()
        {
            int x = new int();
            x = 3;
            int y = new int();
            y = x;
            y = 4;
            Console.WriteLine(x);
            return x;
        }

        static int ReturnValue2()
        {
            MyInt x = new MyInt();
            x.MyValue = 3;
            MyInt y = new MyInt();
            y = x;
            y.MyValue = 4;
            Console.WriteLine(x);
            return x.MyValue;
        }

        static int RecursiveOdd(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return (RecursiveOdd(n - 1) + 2);

            //RecursiveOdd(n = 1)
            // RecursiveOdd(1-1 = 0)  (+2)
            //  return 1;
            // 1 + 2  = 3

            //RecursiveOdd(n = 2)
            // RecursiveOdd(2-1 = 1)   (+2)
            //  RecursiveOdd(1-1 = 0)  (+2)
            //   return 1;
            // 1 + (+2)*2  = 5

            //RecursiveOdd(n = 3)
            // RecursiveOdd(3-1 = 2)  (+2)
            //  RecursiveOdd(2-1 = 1)  (+2)
            //   RecursiveOdd(1-1 = 0)  (+2)
            //    return 1;
            // 1 + (+2)*3  = 7

            //RecursiveOdd(n = 4)
            // RecursiveOdd(4-1 = 3)  (+2)
            //  RecursiveOdd(3-1 = 2)  (+2)
            //   RecursiveOdd(2-1 = 1)  (+2)
            //    RecursiveOdd(1-1 = 0)  (+2)
            //     return 1;
            // 1 + (+2)*4  = 9

            //RecursiveOdd(n = 5)
            // RecursiveOdd(5-1 = 4)  (+2)
            //  RecursiveOdd(4-1 = 3)  (+2)
            //   RecursiveOdd(3-1 = 2)  (+2)
            //    RecursiveOdd(2-1 = 1)  (+2)
            //     RecursiveOdd(1-1 = 0)  (+2)
            //      return 1;
            // 1 + (+2)*5  = 11
        }

        static int RecursiveEven(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return (RecursiveEven(n - 1) + 2);

            //RecursiveEven(n = 1)
            // RecursiveEven(1-1 = 0)  (+2)
            //  return 0;
            // 0 + 2  = 2

            //RecursiveEven(n = 2)
            // RecursiveEven(2-1 = 1)  (+2)
            //  RecursiveEven(1-1 = 0)  (+2)
            //   return 1;
            // 0 + (+2)*2  = 4

            //RecursiveEven(n = 3)
            // RecursiveEven(3-1 = 2)  (+2)
            //  RecursiveEven(2-1 = 1)  (+2)
            //   RecursiveEven(1-1 = 0)  (+2)
            //    return 1;
            // 0 + (+2)*3  = 6

            //RecursiveEven(n = 4)
            // RecursiveEven(4-1 = 3)  (+2)
            //  RecursiveEven(3-1 = 2)  (+2)
            //   RecursiveEven(2-1 = 1)  (+2)
            //    RecursiveEven(1-1 = 0)  (+2)
            //     return 1;
            // 0 + (+2)*4  = 8

            //RecursiveEven(n = 5)
            // RecursiveEven(5-1 = 4)  (+2)
            //  RecursiveEven(4-1 = 3)  (+2)
            //   RecursiveEven(3-1 = 2)  (+2)
            //    RecursiveEven(2-1 = 1)  (+2)
            //     RecursiveEven(1-1 = 0)  (+2)
            //      return 1;
            // 0 + (+2)*5  = 10
        }

        static int RecursiveFibonacci(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 0)
            {
                return 0;
            }
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
            return (RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2));
        }


        static int InterativeOdd(int n)
        {
            //IterativeOdd(1)
            //1 + 2 = 3

            //IterativeOdd(2)
            //1 + 2*2 = 5

            //IterativeOdd(3)
            //1 + 2*3 = 7

            //IterativeOdd(4)
            //1 + 2*4 = 9

            //IterativeOdd(5)
            //1 + 2*5 = 11

            if (n == 0) return 1;

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result += 2;
            }

            return result;
        }

        static int InterativeEven(int n)
        {
            //Skapa​ ​en IterativeEven(int n) funktion​ ​för​ ​att​ ​iterativt​ ​beräkna​ ​det​ ​​n: te​ ​jämna​ ​talet.
            if (n == 0) return 0;

            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += 2;
            }
            return result;
        }

        

        static int InterativeFibonacci(int n)
        {  
            int previous = -1;
            int next = 1;
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum = previous + next;
                previous = next;
                next = sum;
            }
            return sum;
        }
    }

    class MyInt
    {
        public int MyValue;
    }

}

