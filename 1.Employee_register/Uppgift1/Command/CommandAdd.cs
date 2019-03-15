using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.UiConsole.Command
{
    internal class CommandAdd: CommandBase
    {
        public override IEnumerable<string> Flags { get { return new string[] { "add" }; } }
        public override IEnumerable<string> Syntaxes { get { return new string[] { "Lägg till: [add <förnamn> <efternamn> <lön>]" }; } }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public CommandAdd()
        {
        }

        public override bool TryGetValues(string[] arguments)
        {
            Salary = 0;
            FirstName = string.Empty;
            LastName = string.Empty;

            if (arguments.Length == 4)
            {
                if (!decimal.TryParse(arguments[3], out decimal salary))
                {
                    return false;
                }
                Salary = salary;
            }

            if (arguments.Length >= 3)
            {
                LastName = arguments[2];
            }

            if (arguments.Length >= 2)
            {
                FirstName = arguments[1];
            }

            return true;
        }
    }
}