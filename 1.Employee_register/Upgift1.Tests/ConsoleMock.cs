using System.Collections.Generic;
//using Uppgift1.UI;
using EmployeeReg.UiConsole;

namespace NUnitTestProject1
{
    public class ConsoleMock: IConsoleInteraction
    {
        public List<string> ConsoleOutputRows = new List<string>();

        public List<string> ConsoleInputRows = new List<string>();


        public void ShowGoodBye()
        {
            ConsoleOutputRows.Add("personalregistret avslutas!");
            ConsoleOutputRows.Add("Hit any key to exit...");
        }

        public void ShowFaultyInput()
        {
            ConsoleOutputRows.Add("Felaktig inmatning!");
        }

        public void ShowPrompt()
        {
            string prompt = ">";
            ConsoleOutputRows.Add(prompt);
        }

        public void ShowWelcome()
        {
            ConsoleOutputRows.Add("Välkommen till personalregistret!");
        }

        public string[] GetUserInputs()
        {
            if(ConsoleInputRows.Count > 0)
            {
                var userinput = ConsoleInputRows[0];
                ConsoleInputRows.RemoveAt(0);
                return userinput.Split(" ".ToCharArray());
            }
            return new string[] { };
        }

        public void ShowRows(IEnumerable<string> rows)
        {
            foreach (var row in rows)
            {
                ConsoleOutputRows.Add(row);
            }
        }

        public void ClearScreen()
        {
            ConsoleOutputRows.Clear();
        }

    }
}
