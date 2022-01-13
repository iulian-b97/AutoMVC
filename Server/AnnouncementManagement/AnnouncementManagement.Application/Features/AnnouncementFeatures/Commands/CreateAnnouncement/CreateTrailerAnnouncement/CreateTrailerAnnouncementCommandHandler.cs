using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using AnnouncementManagement.Domain.Entities;
using AnnouncementManagement.Domain.Entities.Vehicle;
using AnnouncementManagement.Infrastructure.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTrailerAnnouncement
{
    public class CreateTrailerAnnouncementCommandHandler : IRequestHandler<CreateTrailerAnnouncementCommand, CreateTrailerAnnouncementCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly AnnouncementContext _context;

        public CreateTrailerAnnouncementCommandHandler(IMapper mapper, AnnouncementContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<CreateTrailerAnnouncementCommandResponse> Handle(CreateTrailerAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateTrailerAnnouncementCommandResponse createTrailerCommandResponse = new CreateTrailerAnnouncementCommandResponse();

            Announcement announcement = new Announcement
            {
                Title = request.Announcement.Title,
                Price = request.Announcement.Price,
                Description = request.Announcement.Description,
                SellerId = request.Announcement.SellerId
            };
            announcement.Id = Guid.NewGuid().ToString();

            Trailer trailer = new Trailer
            {
                Mark = request.Trailer.Mark,
                Model = request.Trailer.Model,
                Year = request.Trailer.Year,
                Body = request.Trailer.Body,
                ColorBody = request.Trailer.ColorBody,
                NumberDoors = request.Trailer.NumberDoors,
                AnnouncementId = announcement.Id
            };
            trailer.Id = Guid.NewGuid().ToString();

            await _context.Announcements.AddAsync(announcement);
            await _context.Trailers.AddAsync(trailer);
            await _context.SaveChangesAsync();

            createTrailerCommandResponse.Announcement = _mapper.Map<AnnouncementDto>(announcement);
            createTrailerCommandResponse.Trailer = _mapper.Map<TrailerDto>(trailer);

            return createTrailerCommandResponse;
        }
    }
}
