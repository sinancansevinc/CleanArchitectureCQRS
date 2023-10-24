using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Court.CreateCourt
{
    public class CreateCourtRequest:IRequest<CreateCourtResponse>
    {
        [Required]
        public string CourtName { get; set; }
        [Required]
        public string District { get; set; }
        public string ImageUrl { get; set; }
    }
}
