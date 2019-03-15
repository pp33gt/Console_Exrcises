using System.Collections.Generic;

namespace Uppgift2
{
    public class UserDialog
    {
        public static string FaultyInputMessage = "\nFelaktig inmatning!";

        public static List<string> GetMenu()
        {
            List<string> res = new List<string>() {
                "Välkommen till huvudmenyn!",
                "Meny:",
                "0 - Avsluta",
                "1 - Ungdom eller pensionär (bio köp)",
                "2 - Upprepa tio gånger ",
                "3 - Det tredje ordet ",
            };
            return res;
        }

        public static List<string> GetRowsCinemaGoer(List<CinemaGoer> cinemaGoers)
        {
            List<string> res = new List<string>();
            foreach (var item in cinemaGoers)
            {
                res.Add(GetRowCinemaGoer(item));
            }
            return res;
        }

        public static string GetRowCinemaGoer(CinemaGoer cinemaGoer)
        {
            var res = string.Format("{0} ---> {1} {2} kr \n", cinemaGoer.Age.ToString().PadRight(5),
                CinemaTickets.TicketTypeToString(cinemaGoer.Ticket.TicketType).PadRight(20),
                cinemaGoer.Ticket.Fee.ToString()
                );

            return res;
        }

        public static string GetRowTicketsTotal(int totalTicketSum)
        {
            var res = string.Format(" ".PadRight(30) + "Totalpris: {0} kr \n",
                              totalTicketSum.ToString().PadRight(30)
               );

            return res;
        }
    }
}
