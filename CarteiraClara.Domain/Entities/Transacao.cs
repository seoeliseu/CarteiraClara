using CarteiraClara.Core.DomainObjects;

namespace CarteiraClara.Domain.Entities
{
    public class Transacao(decimal valor, string descricao, int contaId) : Entity, IAggregateRoot
    {
        public decimal Valor { get; set; } = valor;
        public string Descricao { get; set; } = descricao;
        public DateTime Data { get; set; } = DateTime.Now;
        public int ContaId { get; set; } = contaId;

        public virtual Conta Conta { get; set; }
    }
}
