namespace VolgaIT.Account
{
    public class User
    {
        public enum Roles
        {
            User,
            Admin
        }
        private string firstName;
        private string lastName;
        private string username;
        private string password;
        private Roles role;

        public User(string firstName, string lastName, string username, string password, Roles role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public User(string firstName, string lastName, string username, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            role = Roles.User;
        }
    }
}
