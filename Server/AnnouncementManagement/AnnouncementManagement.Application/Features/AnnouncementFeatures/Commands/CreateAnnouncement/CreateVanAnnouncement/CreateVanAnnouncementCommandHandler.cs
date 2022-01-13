using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using AnnouncementManagement.Domain.Entities;
using AnnouncementManagement.Domain.Entities.Vehicle;
using AnnouncementManagement.Infrastructure.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement
{
    public class CreateVanAnnouncementCommandHandler : IRequestHandler<CreateVanAnnouncementCommand, CreateVanAnnouncementCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly AnnouncementContext _context;

        public CreateVanAnnouncementCommandHandler(IMapper mapper, AnnouncementContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<CreateVanAnnouncementCommandResponse> Handle(CreateVanAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateVanAnnouncementCommandResponse createVanCommandResponse = new CreateVanAnnouncementCommandResponse();

            Announcement announcement = new Announcement
            {
                Title = request.Announcement.Title,
                Price = request.Announcement.Price,
                Description = request.Announcement.Description,
                SellerId = request.Announcement.SellerId
            };
            announcement.Id = Guid.NewGuid().ToString();

            Van van = new Van
            {
                Mark = request.Van.Mark,
                Model = request.Van.Model,
                Year = request.Van.Year,
                Km = request.Van.Km,
                HP = request.Van.HP,
                Cm3 = request.Van.Cm3,
                Gearbox = request.Van.Gearbox,
                Speeds = request.Van.Speeds,
                Cylinders = request.Van.Cylinders,
                Traction = request.Van.Traction,
                Body = request.Van.Body,
                ColorBody = request.Van.ColorBody,
                Paint = request.Van.Paint,
                NumberDoors = request.Van.NumberDoors,
                NumberSeats = request.Van.NumberSeats,
                Weight = request.Van.Weight,
                AnnouncementId = announcement.Id
            };
            van.Id = Guid.NewGuid().ToString();

            await _context.Announcements.AddAsync(announcement);
            await _context.Vans.AddAsync(van);
            await _context.SaveChangesAsync();

            createVanCommandResponse.Announcement = _mapper.Map<AnnouncementDto>(announcement);
            createVanCommandResponse.Van = _mapper.Map<VanDto>(van);

            return createVanCommandResponse;
        }
    }
}
