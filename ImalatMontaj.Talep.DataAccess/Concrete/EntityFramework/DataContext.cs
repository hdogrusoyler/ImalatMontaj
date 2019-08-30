using ImalatMontaj.Talep.Entities.Concrete;
using ImalatMontaj.Talep.Entities.Concrete.EfMappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.DataAccess.Concrete.EntityFramework
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Entities.Concrete.Talep> Taleps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TalepMap());
            modelBuilder.ApplyConfiguration(new FotoMap());
        }
    }
}
