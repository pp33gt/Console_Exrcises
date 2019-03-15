using System.Collections.Generic;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInteraction.WriteLines(UserDialog.GetMenu());

            bool exit = false;
            while (!exit)
            {
                ConsoleInteraction.ShowPrompt();
                var userInputKey = ConsoleInteraction.ReadKey();

                switch (userInputKey.KeyChar)
                {
                    case '0':
                        ConsoleInteraction.ShowExiting();
                        exit = true;
                        break;
                    case '1':
                        CinemaGoers cinemaGoers = new CinemaGoers();

                        if (!TryGetUserInputNumParticipants(out int numParticipants))
                        {
                            ConsoleInteraction.WriteLine(UserDialog.FaultyInputMessage);
                            break;
                        }

                        cinemaGoers.Participants = AddCinemaGoers(numParticipants);
                        //cinemaGoers.Participants = DummyData.GetDummyCinemaGoers();

                        var rows = UserDialog.GetRowsCinemaGoer(cinemaGoers.Participants);
                        ConsoleInteraction.WriteLines(rows);

                        var totalRow = UserDialog.GetRowTicketsTotal(cinemaGoers.GetTotalTicketSum());
                        ConsoleInteraction.WriteLine(totalRow);

                        break;
                    case '2':
                        ShowSentenceRepeatedTenTimes();
                        break;
                    case '3':
                        ShowThirdWord();
                        break;
                    default:
                        ConsoleInteraction.WriteLine(UserDialog.FaultyInputMessage);
                        break;
                }
            }
            ConsoleInteraction.ShowHitAnyKeyToExit();
        }

        static bool TryGetUserInputNumParticipants(out int numParticipants)
        {
            ConsoleInteraction.WriteLine("\nAnge hur många i sällskapet:");
            var userInputNumParticipants = ConsoleInteraction.ReadLine();

            if (int.TryParse(userInputNumParticipants, out numParticipants))
            {
                return true;
            }
            return false;
        }

        static List<CinemaGoer> AddCinemaGoers(int numParticipants)
        {
            List<CinemaGoer> res = new List<CinemaGoer>();

            for (var i = 0; i <= numParticipants - 1; i++)
            {
                ConsoleInteraction.WriteLine("\nAnge ålder på deltagare " + (i + 1).ToString() + ":");

                //var row = ConsoleInteraction.GetCursorRow();
                var userInput = ConsoleInteraction.ReadLine();

                if (!int.TryParse(userInput, out int age))
                {
                    ConsoleInteraction.WriteLine(UserDialog.FaultyInputMessage);
                }

                var cinemaGoer = new CinemaGoer(age);
                res.Add(cinemaGoer);
            }
            return res;
        }

        static void ShowSentenceRepeatedTenTimes()
        {
            ConsoleInteraction.WriteLine("\nAnge godtycklig text:");
            var userText = ConsoleInteraction.ReadLine();
            for (var i = 0; i < 10; i++)
            {
                ConsoleInteraction.Write(userText);
            }
        }

        static void ShowThirdWord()
        {
            var isFaultyInput = true;
            ConsoleInteraction.WriteLine("\nAnge en mening med minst 3 ord:");
            var userSentence = ConsoleInteraction.ReadLine();
            var userSentenceWords = userSentence.Split(new char[] { ' ' }, options: System.StringSplitOptions.RemoveEmptyEntries);

            var getWordAtIndex = 2;
            if (userSentenceWords.Length >= getWordAtIndex)
            {
                ConsoleInteraction.WriteLine("\nDet tredje ordet är:" + userSentenceWords[getWordAtIndex]);
                isFaultyInput = false;
            }

            if (isFaultyInput)
            {
                ConsoleInteraction.WriteLine(UserDialog.FaultyInputMessage);
            }
        }
    }
}
