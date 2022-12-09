namespace Domain.Entities.Base;

public abstract class SoftDeleteEntity<T> : EntityBase<T>, ISoftDelete
{
    public DateTime? DeletedOn { get; set; }
}