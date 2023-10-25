using AutoMapper;
using CleanArchitectureCQRS.Application.Context;
using CleanArchitectureCQRS.Application.Court.CreateCourt;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.UpdateCourt
{
    public class UpdateCourtCommandHandler : IRequestHandler<UpdateCourtRequest, UpdateCourtResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICourtDbContext _context;

        public UpdateCourtCommandHandler(IMapper mapper, ICourtDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<UpdateCourtResponse> Handle(UpdateCourtRequest request, CancellationToken cancellationToken)
        {
            var court = _mapper.Map<CleanArchitectureCQRS.Domain.Entities.Court>(request);
            _context.Courts.Update(court);

            await _context.SaveToDbAsync();

            return _mapper.Map<UpdateCourtResponse>(court);



        }
    }
}
