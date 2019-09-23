using Microsoft.EntityFrameworkCore;
using Biblioteca.API.Model;

namespace Biblioteca.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) {}

        public DbSet<Categoria> Categorias{get;set;}
        public DbSet<User> Users{get;set;}
    }
}