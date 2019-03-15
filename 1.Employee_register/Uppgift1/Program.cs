using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.UiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInteraction consoleInteraction = new ConsoleInteraction();
            ProgramFlow programFlow = new ProgramFlow(consoleInteraction);
            programFlow.Run();
        }
    }
}
