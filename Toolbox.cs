namespace VolgaIT
{
    public static class Toolbox
    {
        private static int doctorId;
        private static int hospitalId;
        public static int GenerateDoctorId()
        {
            return doctorId++;
        }

        public static int GenerateHospitalId()
        {
            return hospitalId++;
        }
    }
}
