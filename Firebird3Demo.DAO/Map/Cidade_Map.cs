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
    class Cidade_Map : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidade");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasMaxLength(2).IsFixedLength().IsRequired();
            builder.Property(x => x.Nome).HasMaxLength(60).IsRequired();
            builder.Property(x => x.UFId).IsFixedLength().HasMaxLength(2).IsRequired();

            builder.HasOne(x => x.UF).WithMany().HasForeignKey(x => x.UFId).HasConstraintName("FK_Cidade_UF");
        }
    }
}
