namespace VolgaIT.Account
{
    public class Doctor : User
    {
        private int id;
        public Doctor(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password)
        {
            id = Toolbox.GenerateDoctorId();
        }

        public int Id
        {
            get { return id; }
        }
    }
}
