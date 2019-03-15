using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.UiConsole.Command
{
    internal class CommandPrint : CommandBase
    {
        public override IEnumerable<string> Flags { get { return new string[] { "print" }; } }
        public override IEnumerable<string> Syntaxes { get { return new string[] { "Skriv ut: [print]" }; } }

        public CommandPrint()
        {
        }

        public override bool TryGetValues(string[] arguments)
        {
            return true;
        }
    }
}