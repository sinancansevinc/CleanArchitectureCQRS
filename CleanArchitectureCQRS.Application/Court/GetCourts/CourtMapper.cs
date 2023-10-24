using AutoMapper;
using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.GetCourts
{
    public class CourtMapper : Profile
    {
        public CourtMapper()
        {
            CreateMap<CleanArchitectureCQRS.Domain.Entities.Court, GetCourtsResponse>();
        }
    }
}
