using AnnouncementManagement.Domain.Common;


namespace AnnouncementManagement.Domain.Entities.Vehicle
{
    public class Van : CommonVehicle
    {
        public int Km { get; set; }
        public int HP { get; set; }
        public int Cm3 { get; set; }
        public string Gearbox { get; set; }
        public int Speeds { get; set; }
        public int Cylinders { get; set; }
        public string Traction { get; set; }
        public string Paint { get; set; }
        public int NumberDoors { get; set; }
        public int NumberSeats { get; set; }
        public int Weight { get; set; }

        public virtual string AnnouncementId { get; set; }
        public virtual Announcement Announcement { get; set; }
    }
}
