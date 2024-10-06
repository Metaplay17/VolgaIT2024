using VolgaIT.Account;
using VolgaIT.Hospital;
using VolgaIT.TimetableMS;

namespace VolgaIT.Timetable
{
    public class TaskManager
    {
        private List<HospitalTask> tasks;
        private Dictionary<int, HospitalTask> hospitalTasks;
        private Dictionary<Room, Queue<HospitalTask>> roomTasks;
        private Dictionary<Doctor, Queue<HospitalTask>> doctorTasks;
        public TaskManager()
        {
            tasks = new List<HospitalTask>();
            hospitalTasks = new Dictionary<int, HospitalTask>();
            roomTasks = new Dictionary<Room, Queue<HospitalTask>>();
            doctorTasks = new Dictionary<Doctor, Queue<HospitalTask>>();
        }

        public void AddTask(int hospitalId)
        {

        }
    }
}
