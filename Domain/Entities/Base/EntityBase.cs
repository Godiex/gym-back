namespace Domain.Entities.Base
{
    public class EntityBase<T> : DomainEntity, IEntityBase<T>, ISoftDelete
    {
        public DateTime? DeletedOn { get; set; }
        public virtual T Id { get; set; } = default!;
    }
}


