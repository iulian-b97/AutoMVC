using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Responses;
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

            /*
            AnnouncementResponse announcement = await _announcementRepo.CreateAnnouncement(request.Announcement);
            createVanCommandResponse.Announcement = announcement;
            createVanCommandResponse.Van = await _vanRepo.CreateVan(request.Van); */

            return createVanCommandResponse;
        }
    }
}
