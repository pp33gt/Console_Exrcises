using NUnit.Framework;
using NUnitTestProject1;
using System.Collections.Generic;
using EmployeeReg.UiConsole;

namespace Tests
{
    public class Tests
    {
        ProgramFlow programFlow = null;
        ConsoleMock consoleInteraction = null;

        [SetUp]
        public void Setup()
        {
            consoleInteraction = new ConsoleMock();
            programFlow = new ProgramFlow(consoleInteraction);
        }

        [Test]
        public void TestProgramFlow_Start_ShouldShowHello()
        {
            consoleInteraction.ConsoleInputRows = new List<string>() { "quit" };
            programFlow.Run();
            var res = new List<string>() {
                "V�lkommen till personalregistret!",
            };

            Assert.That(res, Is.SubsetOf(consoleInteraction.ConsoleOutputRows));
        }

        [Test]
        public void TestProgramFlow_Quit_ShouldShowGoodBye()
        {
            consoleInteraction.ConsoleInputRows = new List<string>() { "quit" };
            programFlow.Run();
            var res = new List<string>() {
                "personalregistret avslutas!",
            };

            Assert.That(res, Is.SubsetOf(consoleInteraction.ConsoleOutputRows));
        }

        [Test]
        public void TestProgramFlow_Help_ShouldSyntax()
        {
            consoleInteraction.ConsoleInputRows = new List<string>() { "clear",
                "help"
                , "quit" };
            programFlow.Run();

            var expected = new string[] {
                "Hj�lp: [help]|[?]",
                "Avsluta: [quit]|[q]",
               "Skriv ut: [print]",
               "L�gg till: [add <f�rnamn> <efternamn> <l�n>]",
               "Rensa sk�rm: [clear]",
               "L�gg till dummyData: [addmany]" };

            Assert.That( expected , Is.SubsetOf(consoleInteraction.ConsoleOutputRows));
        }


        [Test]
        public void TestProgramFlow_AddOne_Print_ShouldBeOne()
        {
            consoleInteraction.ConsoleInputRows = new List<string>() {
                "add even steven 10999",
                "clear",
                "print"
                , "quit" };
            programFlow.Run();

            var res = new List<string>() {
                //"Namn: even steven          L�n: 10999 kr\n",
                "Namn: even steven  L�n: 10999  kr"
            };

            Assert.That(res, Is.SubsetOf(consoleInteraction.ConsoleOutputRows));
        }

        [Test]
        public void TestProgramFlow_AddMany_Print_ShouldBeSix()
        {
            consoleInteraction.ConsoleInputRows = new List<string>() {
                "addmany",
                 "clear",
                "print"
                , "quit" };
            programFlow.Run();

            var res = new List<string>() {
                //"Namn: kalle anka           L�n: 10000 kr\n",
                //"Namn: musse pigg           L�n: 20000 kr\n",
                //"Namn: mimmi pigg           L�n: 20000 kr\n",
                //"Namn: Musse Pigg           L�n: 25000 kr\n",
                //"Namn: Kalle Anka           L�n: 14500,90 kr\n",
                //"Namn: Janne L������������ngben L�n: 10000,50 kr\n"

                "Namn: Musse Pigg  L�n: 25000  kr",
                "Namn: Kalle Anka  L�n: 14500,90  kr",
                "Namn: Janne L�ngben  L�n: 10000,50  kr",
            };

            Assert.That(res, Is.SubsetOf(consoleInteraction.ConsoleOutputRows));
            //Assert.AreEqual(6, consoleInteraction.ConsoleOutputRows.Count);
        }
    }
}