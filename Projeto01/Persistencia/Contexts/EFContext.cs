using Persistencia.Migrations;
using Projeto01.Modelo.Cadastros;
using Projeto01.Modelo.Tabelas;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projeto01.Persistencia.Contexts
{
    public class EFContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public EFContext() : base("Asp_Net_MVC_CS") {
            Database.SetInitializer<EFContext>(new MigrateDatabaseToLatestVersion<EFContext, Configuration>());
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}