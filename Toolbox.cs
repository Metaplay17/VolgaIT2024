namespace VolgaIT
{
    public static class Toolbox
    {
        private static int userId;
        private static int doctorId;
        private static int hospitalId;
        private static int taskId;
        public static int GenerateUserId()
        {
            return userId++;
        }
        public static int GenerateDoctorId()
        {
            return doctorId++;
        }

        public static int GenerateHospitalId()
        {
            return hospitalId++;
        }

        public static int GenerateTaskId()
        {
            return taskId++;
        }
    }
}
