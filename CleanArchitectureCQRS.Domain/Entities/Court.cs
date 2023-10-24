using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Entities
{
    public class Court
    {
        public int Id { get; set; }
        public string CourtName { get; set; }
        public string District { get; set; }
        public string ImageUrl { get; set; }
    }
}
