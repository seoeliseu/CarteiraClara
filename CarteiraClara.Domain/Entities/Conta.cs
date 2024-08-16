using CarteiraClara.Domain.Enums;
using CarteiraClara.Core.DomainObjects;

namespace CarteiraClara.Domain.Entities
{
    public class Conta(string nome, TipoContaEnum tipoConta, string mascara, int? contaPaiId) : Entity, IAggregateRoot
    {
        public required string Nome { get; set; } = nome;
        public required TipoContaEnum TipoContaId { get; set; } = tipoConta;
        public required string Mascara { get; set; } = mascara;
        public int? ContaPaiId { get; set; } = contaPaiId;
    }
}
