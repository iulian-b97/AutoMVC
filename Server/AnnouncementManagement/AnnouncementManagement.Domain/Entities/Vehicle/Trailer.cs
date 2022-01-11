using AnnouncementManagement.Domain.Common;


namespace AnnouncementManagement.Domain.Entities.Vehicle
{
    public class Trailer : CommonVehicle
    {
        public string NumberDoors { get; set; }

        public virtual string AnnouncementId { get; set; }
        public virtual Announcement Announcement { get; set; }
    }
}
