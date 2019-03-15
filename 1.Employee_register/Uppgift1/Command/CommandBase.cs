using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.UiConsole.Command
{
    internal abstract class CommandBase//: ICommand
    {
        public abstract IEnumerable<string> Flags { get; }
        public abstract IEnumerable<string> Syntaxes { get; }

        public CommandBase()
        {
        }

        public abstract bool TryGetValues(string[] arguments);

    }
}
