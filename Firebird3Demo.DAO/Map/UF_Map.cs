using Firebird3Demo.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebird3Demo.DAO.Map
{
    class UF_Map : IEntityTypeConfiguration<UF>
    {
        public void Configure(EntityTypeBuilder<UF> builder)
        {
            builder.ToTable("UF");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasMaxLength(2).IsFixedLength().IsRequired();
            builder.Property(x => x.Nome).HasMaxLength(60).IsRequired();
        }
    }
}
