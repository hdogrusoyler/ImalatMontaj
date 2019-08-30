using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.Entities.Concrete.EfMappings
{
    public class TalepMap : IEntityTypeConfiguration<Talep>
    {
        public void Configure(EntityTypeBuilder<Talep> builder)
        {
            builder.Property(e => e.Id).IsRequired();
            builder.Property(e => e.Tip).IsRequired();
            builder.Property(e => e.UrunTanimi).IsRequired().HasMaxLength(200);
            builder.Property(e => e.TalepEdilenYer).IsRequired().HasMaxLength(50);
            builder.Property(e => e.TalepEdenAdSoyad).IsRequired().HasMaxLength(50);
            builder.Property(e => e.TalepEdenTarihi).IsRequired();
            builder.Property(e => e.TalepEdenDepartman).IsRequired().HasMaxLength(50);

            builder.Property(e => e.TalepOnayAdSoyad).HasMaxLength(50);

            builder.Property(e => e.TalepYapanAdSoyad).HasMaxLength(50);
            builder.Property(e => e.TalepYapanDepartman).HasMaxLength(50);

            builder.Property(e => e.TalepKontrolAdSoyad).HasMaxLength(50);
            builder.Property(e => e.TalepKontrolDepartman).HasMaxLength(50);
        }
    }
}
