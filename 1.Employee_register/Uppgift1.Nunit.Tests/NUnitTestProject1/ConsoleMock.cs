using System.Collections.Generic;
using Uppgift1.UI;

namespace NUnitTestProject1
{
    public class ConsoleMock: IConsoleInteraction
    {
        public List<string> ConsoleOutputRows = new List<string>();

        public List<string> ConsoleInputRows = new List<string>();


        public void ShowGoodBye()
        {
            //Console.WriteLine("personalregistret avslutas!");
            ConsoleOutputRows.Add("personalregistret avslutas!");
            //Console.WriteLine("Hit any key to exit...");
            ConsoleOutputRows.Add("Hit any key to exit...");
            //Console.ReadKey();
        }

        public void ShowFaultyInput()
        {
            //Console.WriteLine("Felaktig inmatning!");
            ConsoleOutputRows.Add("Felaktig inmatning!");
        }

        public void ShowPrompt()
        {
            string prompt = ">";
            //Console.Write(prompt);
            ConsoleOutputRows.Add(prompt);
        }

        public void ShowWelcome()
        {
            //Console.WriteLine("Välkommen till personalregistret!");
            ConsoleOutputRows.Add("Välkommen till personalregistret!");
        }

        public string[] GetUserInputs()
        {
            //var userInput = Console.ReadLine();
            if(ConsoleInputRows.Count > 0)
            {
                var userinput = ConsoleInputRows[0];
                ConsoleInputRows.RemoveAt(0);
                return userinput.Split(" ".ToCharArray());
            }
            return new string[] { };
        }

        public void ShowRows(List<string> rows)
        {
            foreach (var row in rows)
            {
                ConsoleOutputRows.Add(row);
                //Console.WriteLine(row);
            }
        }

        public void ClearScreen()
        {
            ConsoleOutputRows.Clear();
        }

    }
}
