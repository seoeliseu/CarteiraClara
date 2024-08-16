using CarteiraClara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarteiraClara.Infra.BancoDados.Mapping
{
    public class TransacaoMap : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.ToTable("Transacoes");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Valor)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.Descricao);

            builder.Property(t => t.Data)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(t => t.ContaId);
        }
    }
}
