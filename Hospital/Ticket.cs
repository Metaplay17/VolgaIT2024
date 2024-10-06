using VolgaIT.Account;

namespace VolgaIT.Hospital
{
    public class Ticket
    {
        private User user;
        private int id;
        public Ticket(User user, int id)
        {
            this.user = user;
            this.id = id;
        }
    }
}
