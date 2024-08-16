using CarteiraClara.Core.DomainObjects;

namespace CarteiraClara.Domain.Entities
{
    public class Transacao(decimal valor, string descricao, int contaId) : Entity, IAggregateRoot
    {
        public required decimal Valor { get; set; } = valor;
        public required string Descricao { get; set; } = descricao;
        public required DateTime Data { get; set; } = DateTime.Now;
        public required int ContaId { get; set; } = contaId;
    }
}
