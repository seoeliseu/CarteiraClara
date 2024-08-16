using CarteiraClara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarteiraClara.Infra.BancoDados.Mapping
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Contas");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(c => c.TipoContaId);

            builder.Property(c => c.Mascara)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(c => c.ContaPaiId);
        }
    }
}
