using AutoMapper;
using CleanArchitectureCQRS.Application.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.CreateCourt
{
    public class CreateCourtCommandHandler : IRequestHandler<CreateCourtRequest, CreateCourtResponse>
    {
        private readonly ICourtDbContext _context;
        private readonly IMapper _mapper;

        public CreateCourtCommandHandler(ICourtDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CreateCourtResponse> Handle(CreateCourtRequest request, CancellationToken cancellationToken)
        {
            var court = _mapper.Map<CleanArchitectureCQRS.Domain.Entities.Court>(request);
            await _context.Courts.AddAsync(court);
            await _context.SaveToDbAsync();

            return _mapper.Map<CreateCourtResponse>(court);
        }
    }
}
