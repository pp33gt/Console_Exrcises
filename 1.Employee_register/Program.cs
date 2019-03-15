using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            string instructions = "\nVad vill du göra?\nAvsluta: [quit]\nSkriv ut: [print]\nLägg till: [add <förnamn> <efternamn> <lön>]";
            string errorMsg = "Felaktig inmatning!";
            string prompt = ">";

            EmployeeRegister register = new EmployeeRegister();
            register.AddDummyEmployees();

            Console.WriteLine("Välkommen till personalregistret!");

            bool exit = false;
            Command command = Command.Undefined;
            decimal salary = 0;
            string lastName = "";
            string firstName = "";

            while (!exit)
            {
                Console.WriteLine(instructions);
                Console.Write(prompt);
                var inputData = Console.ReadLine();
                var isValidInput = TryGetInput(inputData, out command, out firstName, out lastName, out salary);
                if(isValidInput)
                {
                    if (command == Command.Print)
                    {
                        var employees = register.GetEmployees();
                        foreach (var employee in employees)
                        {
                            Console.WriteLine(string.Format("Namn: {0} {1}  Lön: {2}  kr", employee.FirstName, employee.LastName, employee.Salary.ToString()));
                        }
                    }
                    else if (command == Command.Add)
                    {
                        register.AddEmployee(new Employee(firstName, lastName, salary));
                    }
                    else if (command == Command.Quit)
                    {
                        exit = true;
                    }
                    else
                    {
                        Console.WriteLine(errorMsg);
                    }
                }
                else
                {
                    Console.WriteLine(errorMsg);
                }
            }

            Console.WriteLine("personalregistret avslutas!");
            Console.WriteLine("Hit <return> ...");
            Console.ReadLine();

        }
        static bool TryGetInput(string args, out Command command, out string firstName, out string lastName, out decimal salary)
        {
            salary = 0; lastName = firstName = string.Empty;
            command = Command.Undefined;
            var splitChar = " ";
            var splitChars = splitChar.ToCharArray();
            var frags = args.Split(splitChars);

            if (frags.Length == 4)
            {
                if(!decimal.TryParse(frags[3], out salary))
                {
                    return false;
                }
            }

            if (frags.Length >= 3)
            {
                lastName = frags[2];
            }

            if (frags.Length >= 2)
            {
                firstName = frags[1];
            }

            if (frags.Length >= 1)
            {
                Command res;
                if(Enum.TryParse(frags[0], true, out res))
                {
                    command = res;
                }

                if(command == Command.Add && frags.Length < 4)
                {
                    return false;
                }
            }

            return true;
        }

        enum Command
        {
            Quit,
            Print,
            Add,
            Undefined
        }
    }
}
