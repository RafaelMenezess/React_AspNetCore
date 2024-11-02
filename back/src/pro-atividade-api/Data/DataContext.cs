using Microsoft.EntityFrameworkCore;
using pro_atividade_api.Models;

namespace pro_atividade_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Atividade> Atividades { get; set; }
    }
}