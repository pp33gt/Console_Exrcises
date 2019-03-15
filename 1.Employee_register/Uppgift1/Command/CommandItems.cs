using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.UiConsole.Command
{
    internal class CommandItems
    {
        static List<CommandBase> Commands = new List<CommandBase>() { new CommandAdd(), new CommandAddMany(), new CommandClear(), new CommandHelp(), new CommandQuit(), new CommandPrint() };

        internal static bool TryGetCommand(string[] arguments, out CommandBase command)
        {
            command = null;
            if (arguments.Length < 1)
            {
                return false;
            }

            foreach (var commandItem in Commands)
            {
                foreach (var flag in commandItem.Flags)
                {
                    if (flag == arguments[0])
                    {
                        commandItem.TryGetValues(arguments);
                        command = commandItem;
                        return true;
                    }
                }
            }
            return false;
        }

        internal static IEnumerable<string> GetSyntaxes()
        {
            List<string> res = new List<string>();

            foreach (var commandItem in Commands)
            {
                foreach (var syntax in commandItem.Syntaxes)
                {
                    res.Add(syntax);
                }
            }
            return res;
        }
    }
}
