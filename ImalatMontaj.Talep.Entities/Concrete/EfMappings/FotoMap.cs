using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.Entities.Concrete.EfMappings
{
    public class FotoMap : IEntityTypeConfiguration<Foto>
    {
        public void Configure(EntityTypeBuilder<Foto> builder)
        {
            builder.Property(e => e.Id).IsRequired();
            builder.Property(e => e.Yol).IsRequired().HasMaxLength(100);
        }
    }
}
