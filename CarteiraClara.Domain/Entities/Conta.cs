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

        public void AdicionarContaFilha(Conta conta)
        {
            ContasFilhas.Add(conta);
        }

        public void AdicionarTransacao(decimal valor, string descricao)
        {
            var transacao = new Transacao(valor, descricao, Id);
            Transacoes.Add(transacao);
        }

        public virtual TipoConta TipoConta { get; set; }
        public virtual Conta ContaPai { get; set; }
        public virtual ICollection<Conta> ContasFilhas { get; set; } = [];
        public virtual ICollection<Transacao> Transacoes { get; set; } = [];
    }
}
