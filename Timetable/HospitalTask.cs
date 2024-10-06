using VolgaIT.Exceptions;
using VolgaIT.Hospital;

namespace VolgaIT.TimetableMS
{
    public class HospitalTask
    {
        private int id;
        private int hospitalId;
        private int doctorId;
        private DateTime from;
        private DateTime to;
        private Room room;
        private Ticket ticket;

        public HospitalTask(int hospitalId, int doctorId, DateTime from, DateTime to, Room room)
        {
            if (from.Minute % 30 != 0 || to.Minute % 30 != 0 || from.Second != 0 || to.Second != 0 || Math.Abs((to - from).TotalHours) > 12) 
            {
                throw new HospitalTaskFormatException();
            }
            id = Toolbox.GenerateTaskId();
            this.hospitalId = hospitalId;
            this.doctorId = doctorId;
            this.from = from;
            this.to = to;
            this.room = room;
        }

        public void Update(int hospitalId, int doctorId, DateTime from, DateTime to, Room room)
        {
            if (from.Minute % 30 != 0 || to.Minute % 30 != 0 || from.Second != 0 || to.Second != 0 || Math.Abs((to - from).TotalHours) > 12)
            {
                throw new HospitalTaskFormatException();
            }
            if (ticket != null)
            {
                return; // Cannot update if there is ticket
            }
            this.hospitalId = hospitalId;
            this.doctorId = doctorId;
            this.from = from;
            this.to = to;
            this.room = room;
        }

        public Room Room
        {
            get { return room; }
    }
}
