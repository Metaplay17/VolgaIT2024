namespace VolgaIT.Account
{
    public class Doctor
    {
        private int id;
        public Doctor()
        {
            id = Toolbox.GenerateDoctorId();
        }

        public int Id
        {
            get { return id; }
        }
    }
}
