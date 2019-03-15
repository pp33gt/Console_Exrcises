using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.UiConsole.Command
{
    internal class CommandClear : CommandBase
    {
        public override IEnumerable<string> Flags { get { return new string[] { "clear" }; } }
        public override IEnumerable<string> Syntaxes { get { return new string[] { "Rensa skärm: [clear]" }; } }

        public CommandClear()
        {
        }

        public override bool TryGetValues(string[] arguments)
        {
            return true;
        }
    }
}