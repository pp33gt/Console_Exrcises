using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.UiConsole
{
    class ConsoleInteraction: IConsoleInteraction
    {
        public void ShowGoodBye()
        {
            Console.WriteLine("personalregistret avslutas!");
            Console.WriteLine("Hit <return> ...");
            Console.ReadLine();
        }

        public void ShowFaultyInput()
        {
            Console.WriteLine("Felaktig inmatning!");
        }

        public void ShowPrompt()
        {
            string prompt = "?=help>";
            Console.Write(prompt);
        }

        public void ShowWelcome()
        {
            Console.WriteLine("Välkommen till personalregistret!");
        }

        public string[] GetUserInputs()
        {
            var userinput = Console.ReadLine();
            var res = userinput.Split(' ');
            return res;
        }

        public void ShowRows(IEnumerable<string> rows)
        {
            foreach(var row in rows)
            {
                Console.WriteLine(row);
            }
        }

        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
