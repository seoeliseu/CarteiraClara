using CarteiraClara.Core.DomainObjects;
using CarteiraClara.Domain.Enums;

namespace CarteiraClara.Domain.Entities
{
    public class Conta : Entity, IAggregateRoot
    {
        public required string Nome { get; set; }
        public required TipoContaEnum TipoContaId { get; set; }
        public required string Mascara { get; set; }
        public int? ContaPaiId { get; set; }

        public Conta(string nome, TipoContaEnum tipoConta, string mascara)
        {
            Nome = nome;
            TipoContaId = tipoConta;
            Mascara = mascara;
        }

        public Conta(string nome, TipoContaEnum tipoConta, string mascara, int? contaPaiId)
        {
            Nome = nome;
            TipoContaId = tipoConta;
            Mascara = mascara;
            ContaPaiId = contaPaiId;
        }
    }
}
