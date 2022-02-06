using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement
{
    public class CreateVanAnnouncementCommandHandler : IRequestHandler<CreateVanAnnouncementCommand, CreateVanAnnouncementCommandResponse>
    {
        private readonly IAnnouncementRepository _announcementRepo;
        private readonly IVanRepository _vanRepo;

        public CreateVanAnnouncementCommandHandler(IAnnouncementRepository announcementRepo, IVanRepository vanRepo)
        {
            _announcementRepo = announcementRepo;
            _vanRepo = vanRepo;
        }

        public async Task<CreateVanAnnouncementCommandResponse> Handle(CreateVanAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateVanAnnouncementCommandResponse createVanCommandResponse = new CreateVanAnnouncementCommandResponse();

            AnnouncementResponse announcement = new AnnouncementResponse
            {
                Title = request.Title,
                Description = request.Description,
                Price = request.Price
            };
            VanResponse van = new VanResponse
            {
                Mark = request.Mark,
                Model = request.Model,
                Year = request.Year,
                Body = request.Body,
                ColorBody = request.ColorBody,
                Km = request.Km,
                HP = request.HP,
                Cm3 = request.Cm3,
                Gearbox = request.Gearbox,
                Speeds = request.Speeds,
                Cylinders = request.Cylinders,
                Traction = request.Traction,
                Paint = request.Paint,
                NumberDoors = request.NumberDoors,
                NumberSeats = request.NumberSeats,
                Weight = request.Weight
            };

            createVanCommandResponse.Announcement = await _announcementRepo.CreateAnnouncement(announcement);
            createVanCommandResponse.Van = await _vanRepo.CreateVan(van);

            return createVanCommandResponse;
        }
    }
}
