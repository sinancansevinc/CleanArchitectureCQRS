using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.GetCourt
{
    public class GetCourtMapper:Profile
    {
        public GetCourtMapper()
        {
            CreateMap<CleanArchitectureCQRS.Domain.Entities.Court, GetCourtResponse>();
        }
    }
}
