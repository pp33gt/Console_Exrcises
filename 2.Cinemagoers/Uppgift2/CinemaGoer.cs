namespace Uppgift2
{
    public class CinemaGoer
    {
        public int Age = 0;
        public CinemaTicket Ticket;

        public CinemaGoer(int age)
        {
            Age = age;
            Ticket = CinemaTicket.GetTicketType(age);
        }
    }
}
