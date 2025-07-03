using Wpm.Management.Domain.ValueObjects;

namespace Wpm.Management.Domain.Entiities;



/* USING int be generally avoided in Domain Driven Design, 
   Using Guid for entity IDs avoids exposing predictable sequences,
   supports global uniqueness across distributed systems, 
   and aligns with the domain’s conceptual identity.

  In contrast, int IDs tie your domain model to database implementation details, 
  risking collisions and leaking sensitive growth patterns

  public int Id { set; get; }

  */


/*  PRIMITIVE OBESSION 
 * Problems with basic data types is that there general purpose and do not convey any busssiness logic or intent 
 If we rely on them we risk falling the trap of primitive obsession. 
 This happens we only use basic data types (Anti-pattern) 
 DDD recommends using value object instead 
 */

public class Pet : Entity
{

    public Pet(
        Guid id,
        string name,
        int age,
        string color,
        Weight weight,
        SexOfPet sexOfPet,
        BreedId breedId)
    {
        Id = id;
        Name = name;
        Age = age;
        Color = color;
        Weight = weight;
        SexOfPet = sexOfPet;
        BreedId = breedId;
    }

    public string? Name { get; init; }

    public int Age { get; init; }

    public string Color { get; init; }

    //public decimal Weight { set; get; }
    /* If given a negative value there will be no problem and it will be stored. 
       Or even add maximum value which is gonna work but obviously these are incoherent values
       So let us create a value object for weight. A value object represents a value unlike primitive data types they do not 
       rely on identity they only hold the value
    
        For Example Name,Age,Color,Weight can be value objects
     */

    public Weight Weight { get; init; }
    public SexOfPet SexOfPet { get; init; }

    //FOR ADDING GUID VALIDATION 
    public BreedId BreedId { get; init; }

}

public enum SexOfPet
{
    Male,
    Female
}