namespace VolgaIT.Hospital
{
    public class Hospital
    {
        private int id;
        private string name;
        private Dictionary<string, Room> rooms;
        private string address;
        private string contactPhone;

        public Hospital(string name, string[] rooms, string address, string contactPhone)
        {
            id = Toolbox.GenerateHospitalId();
            this.name = name;
            this.rooms = new Dictionary<string, Room>();
            for (int i = 0; i < rooms.Length; i++)
            {
                this.rooms.Add(rooms[i], new Room(rooms[i]));
            }
            this.address = address;
            this.contactPhone = contactPhone;
        }

        public Room GetRoom(string roomName)
        {
            return rooms[roomName];
        }
    }
}
