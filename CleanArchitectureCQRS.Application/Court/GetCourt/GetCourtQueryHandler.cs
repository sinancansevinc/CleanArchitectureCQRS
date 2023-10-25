using AutoMapper;
using CleanArchitectureCQRS.Application.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.GetCourt
{
    public class GetCourtQueryHandler : IRequestHandler<GetCourtRequest, GetCourtResponse>
    {
        private readonly ICourtDbContext _context;
        private readonly IMapper _mapper;

        public GetCourtQueryHandler(ICourtDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetCourtResponse> Handle(GetCourtRequest request, CancellationToken cancellationToken)
        {
            var court = await  _context.Courts.FirstOrDefaultAsync(p => p.Id == request.Id);

            return _mapper.Map<GetCourtResponse>(court);
        }
    }
}
