using ControleDeEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Persistencia
{
    public class MercadoContext : DbContext
    {
        public DbSet<Alimentos> Alimentos { get; set; }
        public MercadoContext(DbContextOptions op) : base(op) { }

    }
}
