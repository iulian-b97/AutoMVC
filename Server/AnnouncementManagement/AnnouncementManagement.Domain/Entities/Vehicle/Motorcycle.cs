using AnnouncementManagement.Domain.Common;


namespace AnnouncementManagement.Domain.Entities.Vehicle
{
    public class Motorcycle : CommonVehicle
    {
        public int Km { get; set; }
        public int HP { get; set; }
        public int Cm3 { get; set; }
        public string Gearbox { get; set; }

        public virtual string AnnouncementId { get; set; }
        public virtual Announcement Announcement { get; set; }
    }
}
