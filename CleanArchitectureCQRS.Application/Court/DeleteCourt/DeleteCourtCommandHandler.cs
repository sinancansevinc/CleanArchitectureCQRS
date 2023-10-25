using CleanArchitectureCQRS.Application.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.DeleteCourt
{
    public class DeleteCourtCommandHandler:IRequestHandler<DeleteCourtRequest,DeleteCourtResponse>
    {
        private readonly ICourtDbContext _context;

        public DeleteCourtCommandHandler(ICourtDbContext context)
        {
            _context = context;
        }

        public async Task<DeleteCourtResponse> Handle(DeleteCourtRequest request, CancellationToken cancellationToken)
        {
            var court = await _context.Courts.FirstOrDefaultAsync(p => p.Id == request.Id);
            
            if(court is null)
                    return new DeleteCourtResponse { IsSuccess = false };

            _context.Courts.Remove(court);
            await _context.SaveToDbAsync();

            return new DeleteCourtResponse { IsSuccess = true };
            
            
        }
    }
}
