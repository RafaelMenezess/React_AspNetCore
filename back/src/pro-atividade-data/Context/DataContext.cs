using Microsoft.EntityFrameworkCore;
using pro_atividade_data.Mappings;
using pro_atividade_domain.Entities;

namespace pro_atividade_data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Atividade> Atividades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtividadeMap());
        }
    }
}