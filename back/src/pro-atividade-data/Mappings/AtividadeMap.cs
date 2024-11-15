using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pro_atividade_domain.Entities;

namespace pro_atividade_data.Mappings
{
    public class AtividadeMap : IEntityTypeConfiguration<Atividade>
    {
        public void Configure(EntityTypeBuilder<Atividade> builder)
        {
            builder.ToTable("Atividades");

            builder.Property(a => a.Titulo)
                .HasColumnType("varchar(100)");

            builder.Property(a => a.Descricao)
                .HasColumnType("varchar(255)");
        }
    }
}