using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using AnnouncementManagement.Domain.Entities;
using AnnouncementManagement.Domain.Entities.Vehicle;
using AnnouncementManagement.Infrastructure.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement
{
    public class CreateMotorcycleAnnouncementCommandHandler : IRequestHandler<CreateMotorcycleAnnouncementCommand, CreateMotorcycleAnnouncementCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly AnnouncementContext _context;

        public CreateMotorcycleAnnouncementCommandHandler(IMapper mapper, AnnouncementContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<CreateMotorcycleAnnouncementCommandResponse> Handle(CreateMotorcycleAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateMotorcycleAnnouncementCommandResponse createMotorcycleCommandResponse = new CreateMotorcycleAnnouncementCommandResponse();

            Announcement announcement = new Announcement
            {
                Title = request.Announcement.Title,
                Price = request.Announcement.Price,
                Description = request.Announcement.Description,
                SellerId = request.Announcement.SellerId
            };
            announcement.Id = Guid.NewGuid().ToString();

            Motorcycle motorcycle = new Motorcycle
            {
                Mark = request.Motorcycle.Mark,
                Model = request.Motorcycle.Model,
                Year = request.Motorcycle.Year,
                Km = request.Motorcycle.Km,
                HP = request.Motorcycle.HP,
                Cm3 = request.Motorcycle.Cm3,
                Gearbox = request.Motorcycle.Gearbox,
                Body = request.Motorcycle.Body,
                ColorBody = request.Motorcycle.ColorBody,
                AnnouncementId = announcement.Id
            };
            motorcycle.Id = Guid.NewGuid().ToString();

            await _context.Announcements.AddAsync(announcement);
            await _context.Motorcycles.AddAsync(motorcycle);
            await _context.SaveChangesAsync();

            createMotorcycleCommandResponse.Announcement = _mapper.Map<AnnouncementDto>(announcement);
            createMotorcycleCommandResponse.Motorcycle = _mapper.Map<MotorcycleDto>(motorcycle);

            return createMotorcycleCommandResponse;
        }
    }
}
