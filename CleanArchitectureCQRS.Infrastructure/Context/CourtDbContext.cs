using CleanArchitectureCQRS.Application.Context;
using CleanArchitectureCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Infrastructure.Context
{
    public class CourtDbContext : DbContext, ICourtDbContext
    {
        public CourtDbContext(DbContextOptions<CourtDbContext> options) : base(options)
        {

        }

        public DbSet<Court> Courts { get; set; }

        public async Task<int> SaveToDbAsync()
        {
            return await SaveChangesAsync();
        }
    }
}