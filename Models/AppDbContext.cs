using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XOPOW.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Morodec> Morodecs { get;set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Morodec>().HasData(new Morodec { Id = 1, Name = "Rodec", Size = 14, Date = new DateTime(2001,12,16), LOLRank = "Ajron3", Address = "Do Pískovny 72, Mníšek", Term = "Není Chálec jako chálec"  });
        }
    }
}
