using VolgaIT.Hospital;

namespace VolgaIT.TimetableMS
{
    public class TimetableMS
    {
        private List<Hospital.Hospital> hospitals;
        private List<HospitalTask> tasks;
        public TimetableMS()
        {
            hospitals = new List<Hospital.Hospital>();
            tasks = new List<HospitalTask>();
        }
        public void AddTask(int hospitalId, int doctorID, DateTime from, DateTime to, string room) // POST
        {
            Room hospitalRoom = hospitals[hospitalId].GetRoom(room);
            HospitalTask task = new HospitalTask(hospitalId, doctorID, from, to, hospitalRoom);
            tasks.Add(task);
        }

        public void UpdateTask(int id, int hospitalId, int doctorID, DateTime from, DateTime to, string room) // PUT
        {
            tasks[id].Update(hospitalId, doctorID, from, to, hospitals[hospitalId].GetRoom(room));
        }

        public void RemoveTask(int id)
        {
            tasks.RemoveAt(id);
        }

        public void RemoveDoctorTasks(int doctorId)
        {

        }
    }
}
