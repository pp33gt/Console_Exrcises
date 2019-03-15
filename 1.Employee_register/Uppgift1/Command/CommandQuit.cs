using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.UiConsole.Command
{
    internal class CommandQuit: CommandBase
    {
        public override IEnumerable<string> Flags { get { return new string[] { "quit", "q" }; } }
        public override IEnumerable<string> Syntaxes { get { return new string[] { "Avsluta: [quit]|[q]" }; } }

        public CommandQuit()
        {
        }

        public override bool TryGetValues(string[] arguments)
        {
            return true;
        }
    }
}