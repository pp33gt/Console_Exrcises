using System.Collections.Generic;

namespace EmployeeReg.UiConsole
{
    public interface IConsoleInteraction
    {
        void ShowGoodBye();

        void ShowFaultyInput();

        void ShowPrompt();

        void ShowWelcome();

        string[] GetUserInputs();

        void ShowRows(IEnumerable<string> rows);

        void ClearScreen();
    }
}
