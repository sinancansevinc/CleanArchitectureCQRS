using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.GetCourts
{
    public class GetCourtsRequest:IRequest<List<GetCourtsResponse>>
    {
        
    }
}
