namespace Wpm.Management.Domain;



/* USING int be generally avoided in Domain Driven Design, 
   Using Guid for entity IDs avoids exposing predictable sequences,
  supports global uniqueness across distributed systems, 
  and aligns with the domain’s conceptual identity.

  In contrast, int IDs tie your domain model to database implementation details, 
  risking collisions and leaking sensitive growth patterns

  public int Id { set; get; }

  */





public class Pet : Entity
{

  
    public Pet(Guid id)
    {
        Id = Id; 
    }
    public string? Name { get; init;  }

    public int Age { get; init; }


}
