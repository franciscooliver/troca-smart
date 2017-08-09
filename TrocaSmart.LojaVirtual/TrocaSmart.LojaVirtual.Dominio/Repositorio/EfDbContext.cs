using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocaSmart.LojaVirtual.Dominio.Entidade;

namespace TrocaSmart.LojaVirtual.Dominio.Repositorio
{
   public class EfDbContext : DbContext
    {
        //Entity é responsavel por mapea o banco
        //Apontando o repositorio
        public DbSet<Produto> Produtos { get; set; }

        //Remover a pluralizacao do entity
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
