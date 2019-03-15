using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.UiConsole.Command
{
    internal class CommandHelp: CommandBase
    {
        public override IEnumerable<string> Flags { get { return new string[] { "help", "?" }; } }
        public override IEnumerable<string> Syntaxes { get { return new string[] { "Hjälp: [help]|[?]" }; } }

        public CommandHelp()
        {
        }

        public override bool TryGetValues(string[] arguments)
        {
            return true;
        }
    }
}