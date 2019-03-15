using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeReg.UiConsole.Command;
using EmployeeReg.BL.DomainEntities;

namespace EmployeeReg.UiConsole
{
    public class ProgramFlow
    {
        private IConsoleInteraction consoleInteraction;

        public ProgramFlow(IConsoleInteraction consoleInteraction)
        {
            this.consoleInteraction = consoleInteraction;
        }

        public void Run()
        {
            EmployeeRegister register = new EmployeeRegister();

            consoleInteraction.ShowWelcome();

            bool exit = false;
            while (!exit)
            {
                consoleInteraction.ShowPrompt();
                var inputData = consoleInteraction.GetUserInputs();

                CommandBase cmd;
                if (TryGetCommand(inputData, out cmd))
                {
                    if (cmd is CommandHelp)
                    {
                        consoleInteraction.ShowRows(CommandItems.GetSyntaxes());
                    }
                    else if (cmd is CommandQuit)
                    {
                        exit = true;
                    }
                    else if (cmd is CommandAdd)
                    {
                        var cmdAdd = cmd as CommandAdd;
                        register.AddEmployee(new Employee(cmdAdd.FirstName, cmdAdd.LastName, cmdAdd.Salary));
                    }
                    else if (cmd is CommandClear)
                    {
                        consoleInteraction.ClearScreen();
                    }
                    else if (cmd is CommandAddMany)
                    {
                        List<Employee> dummys = new List<Employee>() {
                            new Employee("Musse", "Pigg", 25000),
                            new Employee("Kalle", "Anka", 14500.90m),
                            new Employee("Janne", "Långben", 10000.50m),
                        };
                        foreach(var employee in dummys)
                        {
                            register.AddEmployee(employee);
                        }
                    }
                    else if (cmd is CommandPrint)
                    {
                        var employees = register.GetEmployees();
                        foreach (var employee in employees)
                        {
                            consoleInteraction.ShowRows(new string[] { string.Format("Namn: {0} {1}  Lön: {2}  kr", employee.FirstName, employee.LastName, employee.Salary.ToString()) });
                        }
                    }
                    else
                    {
                        consoleInteraction.ShowFaultyInput();
                    }
                }
            }

            consoleInteraction.ShowGoodBye();
        }

        bool TryGetCommand(string[] flags, out CommandBase command)
        {
            command = null;
            if (flags.Length > 0)
            {
                if (CommandItems.TryGetCommand(flags, out command))
                {
                    return true;
                }
                consoleInteraction.ShowFaultyInput();
            }
            return false;
        }
    }
}
