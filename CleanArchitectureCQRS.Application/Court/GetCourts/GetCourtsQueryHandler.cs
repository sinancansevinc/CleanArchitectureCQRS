using AutoMapper;
using CleanArchitectureCQRS.Application.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.GetCourts
{
    public class GetCourtsQueryHandler : IRequestHandler<GetCourtsRequest, List<GetCourtsResponse>>
    {
        private readonly ICourtDbContext _context;
        private readonly IMapper _mapper;

        public GetCourtsQueryHandler(ICourtDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetCourtsResponse>> Handle(GetCourtsRequest request, CancellationToken cancellationToken)
        {
            var courts = await _context.Courts.ToListAsync();

            return _mapper.Map<List<GetCourtsResponse>>(courts);
        }
    }
}
