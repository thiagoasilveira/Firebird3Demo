using Firebird3Demo.DAO.Map;
using Firebird3Demo.DTO;
using FirebirdSql.EntityFrameworkCore.Firebird.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Firebird3Demo.DAO
{
    public class FbContext : DbContext
    {
        private string _connectionString = @"User=SYSDBA;Password=masterkey;Database=D:\CSharp\Demo\Firebird3Demo\Dados\FIREBIRD3DEMO.FDB;DataSource=localhost;Port=3051; Dialect=3; Charset=WIN1252; Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192; ServerType=0;";

        public FbContext() : base()
        {
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseFirebird(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Cidade_Map());
            modelBuilder.ApplyConfiguration(new Pessoa_Map());
            modelBuilder.ApplyConfiguration(new UF_Map());
        }

        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<UF> UF{ get; set; }
    }
}
