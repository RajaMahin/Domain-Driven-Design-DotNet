namespace Wpm.Management.Domain;

public class Pet : IEquatable<Pet>
{
    /* USING int be generally avoided in Domain Driven Design, 
     Using Guid for entity IDs avoids exposing predictable sequences,
    supports global uniqueness across distributed systems, 
    and aligns with the domain’s conceptual identity.
    
    In contrast, int IDs tie your domain model to database implementation details, 
    risking collisions and leaking sensitive growth patterns
    
    public int Id { set; get; }

    */

    public Guid Id { set; get; }

    public string? Name { set; get; }

    public int Age { set; get; }


    public bool Equals(Pet? other)
    {
        return other?.Id == Id;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public static bool operator ==(Pet? right, Pet Left)
    {
        return Left?.Id == right?.Id;
    }

    public static bool operator !=(Pet? right, Pet Left)
    {
        return Left?.Id != right?.Id;
    }


}
