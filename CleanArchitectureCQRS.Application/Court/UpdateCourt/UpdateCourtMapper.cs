using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.UpdateCourt
{
    public class UpdateCourtMapper:Profile
    {
        public UpdateCourtMapper()
        {
            CreateMap<UpdateCourtRequest, CleanArchitectureCQRS.Domain.Entities.Court>();
            CreateMap<CleanArchitectureCQRS.Domain.Entities.Court, UpdateCourtResponse>();
        }
    }
}
