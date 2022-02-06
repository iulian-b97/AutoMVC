using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Responses;
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

            /*
            AnnouncementResponse announcement = await _announcementRepo.CreateAnnouncement(request.Announcement);
            createMotorcycleCommandResponse.Announcement = announcement;
            createMotorcycleCommandResponse.Motorcycle = await _motorcycleRepo.CreateMotorcycle(request.Motorcycle); */

            return createMotorcycleCommandResponse;
        }
    }
}
