namespace VolgaIT.Account
{
    public class AccountMS
    {
        public void SignUp(string firstName, string lastName, string username, string password) // POST
        {
            User user = new User(firstName, lastName, username, password);
            // Database
        }

        public bool SignIn(string username, string password, out string token) // POST
        {
            // Database + JWT authintification
            return false;
        }

        public void SignOut() // PUT
        {

        }

        public bool Validate(string accessToken) // GET
        {
            return false;
        }

        public void Refresh(string accessToken) // POST
        {

        }

        public User Me(string accessToken) // GET
        {

        }

        public void Update(string firstName, string lastName, string password) // PUT
        {

        }

        public User[] AccountsList(int from, int count) // GET
        {
            // Database
        }

        public void AdminAddAccount(string firstName, string lastName, string username, string password, string[] roles)
        {

        }

        public void AdminUpdate(int id, string firstName, string lastName, string username, string password)
        {

        }

        public void DeleteAccount(int id)
        {

        }

        public Doctor[] GetDoctors()
        {

        }

        public Doctor GetDoctor(int id)
        {

        }

    } 
}
