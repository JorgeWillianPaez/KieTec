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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
