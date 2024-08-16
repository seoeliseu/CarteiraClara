using CarteiraClara.Core.DomainObjects;

namespace CarteiraClara.Domain.Entities
{
    public class TipoConta(string nome) : Entity, IAggregateRoot
    {
        public string Nome { get; set; } = nome;
    }
}
