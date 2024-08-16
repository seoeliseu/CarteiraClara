namespace CarteiraClara.Core.DomainObjects
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }
    }
}
