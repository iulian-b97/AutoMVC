using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using AnnouncementManagement.Application.Models.Requests;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Queries.GetAnnouncement
{
    public class GetAnnouncementQueryHandler : IRequestHandler<GetAnnouncementQuery, AnnouncementRequest>
    {
        private readonly IAnnouncementRepository _repository;
        private readonly IMapper _mapper;

        public GetAnnouncementQueryHandler(IAnnouncementRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AnnouncementRequest> Handle(GetAnnouncementQuery request, CancellationToken cancellationToken)
        {
            var announcement = await _repository.GetAnnouncementByIdAsync("159fd9bc-f18b-43b3-9544-bfdf30746648");

            return _mapper.Map<AnnouncementRequest>(announcement);
        }
    }
}
