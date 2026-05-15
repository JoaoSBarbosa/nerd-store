namespace NerdStore.Core.DomainObjects.Model;

public abstract class Entity
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }

    protected Entity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTimeOffset.UtcNow;
        UpdateAt = DateTimeOffset.UtcNow;
    }
    public override bool Equals(object? obj)
    {
        var compareTo = obj as Entity;
        if (ReferenceEquals(this, compareTo)) return true;
        if ( ReferenceEquals(null, compareTo)) return false;
        return Id.Equals(compareTo.Id);
    }

    protected bool Equals(Entity other)
    {
        return Id.Equals(other.Id) && CreatedAt.Equals(other.CreatedAt) && Nullable.Equals(UpdateAt, other.UpdateAt);
    }

    public override int GetHashCode()
    {
        return (GetType().GetHashCode() * 907) + Id.GetHashCode();
    }

    public static bool operator ==(Entity left, Entity right)
    {
        if (ReferenceEquals(left, null) && ReferenceEquals(right, null)) return true;
        if (ReferenceEquals( left, null) || ReferenceEquals(right, null)) return  false;
        
        return left.Equals(right);
    }

    public static bool operator !=(Entity left, Entity right)
    {
        return !(left == right);
    }

    public override string ToString()
    {
        return $"{GetType().Name} | [ID={Id}]";
    }
}