namespace EShop.Domain.Common.Models;

public abstract class AggregateRoot<TId, TIdType> : Entity<TId>
    where TId : notnull, AggregateRootId<TIdType>
    where TIdType: notnull
{
    public new AggregateRootId<TIdType> Id { get; protected set; }

    protected AggregateRoot(TId id)
    {
        Id = id;
    }

    #pragma warning disable CS8618
    protected AggregateRoot()
    {
    }
    #pragma warning restore CS8618
}
