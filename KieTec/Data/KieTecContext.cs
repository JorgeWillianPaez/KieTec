using KieTec.Models;
using Microsoft.EntityFrameworkCore;

namespace KieTec.Data
{
    public class KieTecContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public KieTecContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Fornecedor)
                .WithMany()
                .HasForeignKey(p => p.FornecedorId)
                .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(modelBuilder);
        }
    }
}
