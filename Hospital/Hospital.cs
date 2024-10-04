namespace VolgaIT.Hospital
{
    public class Hospital
    {
        private int id;
        private string name;
        private Room[] rooms;
        private string address;
        private string contactPhone;

        public Hospital(string name, string[] rooms, string address, string contactPhone)
        {
            this.id = Toolbox.GenerateHospitalId();
            this.name = name;
            this.rooms = new Room[rooms.Length];
            for (int i = 0; i < rooms.Length; i++)
            {
                this.rooms[i] = new Room(rooms[i]);
            }
            this.address = address;
            this.contactPhone = contactPhone;
        }
    }
}
