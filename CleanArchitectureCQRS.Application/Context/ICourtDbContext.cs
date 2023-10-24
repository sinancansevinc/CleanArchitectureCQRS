using CleanArchitectureCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Context
{
    public interface ICourtDbContext
    {
        DbSet<CleanArchitectureCQRS.Domain.Entities.Court> Courts { get; set; }
        Task<int> SaveToDbAsync();
    }
}
