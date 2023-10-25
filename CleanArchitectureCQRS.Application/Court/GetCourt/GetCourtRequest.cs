using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.GetCourt
{
    public class GetCourtRequest:IRequest<GetCourtResponse>
    {
        public int Id { get; set; }
    }
}
