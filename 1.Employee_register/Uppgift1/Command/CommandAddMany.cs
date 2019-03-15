using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.UiConsole.Command
{
    internal class CommandAddMany : CommandBase
    {
        public override IEnumerable<string> Flags { get { return new string[] { "addmany" }; } }
        public override IEnumerable<string> Syntaxes { get { return new string[] { "Lägg till dummyData: [addmany]" }; } }

        public CommandAddMany()
        {
        }

        public override bool TryGetValues(string[] arguments)
        {
            return true;
        }
    }
}