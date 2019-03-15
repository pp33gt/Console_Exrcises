using System;
using System.Collections.Generic;

namespace Uppgift2
{
    public class CinemaTickets
    {
        public static Dictionary<TicketType, CinemaTicket> Prices = new Dictionary<TicketType, CinemaTicket>() {
            { TicketType.Free, new CinemaTicket(TicketType.Free, 0 ) },
            { TicketType.Youth, new CinemaTicket(TicketType.Youth, 80 ) },
            { TicketType.Pensioner, new CinemaTicket(TicketType.Pensioner, 90 ) },
            { TicketType.Standard, new CinemaTicket(TicketType.Standard, 120 ) },
            { TicketType.Unknown, new CinemaTicket(TicketType.Unknown, 0 ) }
        };

        public CinemaTickets()
        {
        }

        public static string TicketTypeToString(TicketType type)
        {
            switch (type)
            {
                case TicketType.Free:
                    return "Gratis";
                case TicketType.Youth:
                    return "Ungdomspris";
                case TicketType.Pensioner:
                    return "Pensionärspris";
                case TicketType.Standard:
                    return "Standardpris";
            }
            throw new Exception("Error: Unknown TicketType");
        }
    }
}
