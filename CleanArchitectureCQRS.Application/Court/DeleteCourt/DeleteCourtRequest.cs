using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.DeleteCourt
{
    public class DeleteCourtRequest:IRequest<DeleteCourtResponse>
    {
        public int Id { get; set; }
    }
}
