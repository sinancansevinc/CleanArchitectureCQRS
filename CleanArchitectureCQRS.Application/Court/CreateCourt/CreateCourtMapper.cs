using AutoMapper;
using CleanArchitectureCQRS.Application.Court.GetCourts;
using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.CreateCourt
{
    public class CreateCourtMapper:Profile
    {
        public CreateCourtMapper()
        {
            CreateMap<CreateCourtRequest, CleanArchitectureCQRS.Domain.Entities.Court>();
            CreateMap<CleanArchitectureCQRS.Domain.Entities.Court, CreateCourtResponse>();


        }
    }
}
