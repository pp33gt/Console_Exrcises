using System.Collections.Generic;

namespace Uppgift2
{
    public class CinemaGoers
    {
        public List<CinemaGoer> Participants = new List<CinemaGoer>();
        public int TotalTicketSum = 0;

        public int GetTotalTicketSum()
        {
            foreach (var participant in Participants)
            {
                TotalTicketSum = TotalTicketSum + participant.Ticket.Fee;
            }

            return TotalTicketSum;
        }
    }
}
