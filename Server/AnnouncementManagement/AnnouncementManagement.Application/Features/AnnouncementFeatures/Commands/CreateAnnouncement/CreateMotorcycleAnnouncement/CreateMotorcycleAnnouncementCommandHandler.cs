using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement
{
    public class CreateMotorcycleAnnouncementCommandHandler : IRequestHandler<CreateMotorcycleAnnouncementCommand, CreateMotorcycleAnnouncementCommandResponse>
    {
        private readonly IAnnouncementRepository _announcementRepo;
        private readonly IMotorcycleRepository _motorcycleRepo;

        public CreateMotorcycleAnnouncementCommandHandler(IAnnouncementRepository announcementRepo, IMotorcycleRepository motorcycleRepo)
        {
            
            _announcementRepo = announcementRepo;
            _motorcycleRepo = motorcycleRepo;
        }

        public async Task<CreateMotorcycleAnnouncementCommandResponse> Handle(CreateMotorcycleAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateMotorcycleAnnouncementCommandResponse createMotorcycleCommandResponse = new CreateMotorcycleAnnouncementCommandResponse();

            AnnouncementResponse announcement = new AnnouncementResponse
            {
                Title = request.Title,
                Description = request.Description,
                Price = request.Price
            };
            MotorcycleResponse motorcycle = new MotorcycleResponse
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
            };

            createMotorcycleCommandResponse.Announcement = await _announcementRepo.CreateAnnouncement(announcement);
            createMotorcycleCommandResponse.Motorcycle = await _motorcycleRepo.CreateMotorcycle(motorcycle);

            return createMotorcycleCommandResponse;
        }
    }
}
