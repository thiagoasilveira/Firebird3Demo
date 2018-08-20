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
    internal class Pessoa_Map : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().IsFBAutoGenerate();
            builder.Property(x => x.Nome).HasMaxLength(60).IsRequired();
            builder.Property(x => x.NomeFantasia).HasMaxLength(60);
            builder.Property(x => x.Endereco).HasMaxLength(60);
            builder.Property(x => x.Numero).HasMaxLength(10);
            builder.Property(x => x.Complemento).HasMaxLength(30);
            builder.Property(x => x.Bairro).HasMaxLength(30);
            builder.Property(x => x.CidadeId).HasMaxLength(7).IsRequired();
            builder.Property(x => x.CEP).HasMaxLength(7);
            builder.Property(x => x.Telefone).HasMaxLength(12);
            builder.Property(x => x.Ativo).IsRequired();

            builder.HasOne(x => x.Cidade).WithMany().HasForeignKey(x => x.CidadeId).HasConstraintName("FK_Pessoa_Cidade");
        }
    }

}
