namespace Uppgift2
{
    public class CinemaTicket
    {
        public int Fee = 0;
        public TicketType TicketType = TicketType.Unknown;

        public CinemaTicket(TicketType type, int fee)
        {
            Fee = fee;
            TicketType = type;
        }

        public static CinemaTicket GetTicketType(int age)
        {
            TicketType type = TicketType.Unknown;

            if (age < 5 || age > 100)
            {
                type = TicketType.Free;
            }
            else if (age < 20)
            {
                type = TicketType.Youth;
            }
            else if (age > 64)
            {
                type = TicketType.Pensioner;
            }
            else
            {
                type = TicketType.Standard;
            }
            return CinemaTickets.Prices[type];
        }
    }
}
