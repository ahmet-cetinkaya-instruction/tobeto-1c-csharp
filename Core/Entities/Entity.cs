namespace Core.Entities;

public abstract class Entity<TId>
{
    public TId Id { get; set; } // primary key

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}
