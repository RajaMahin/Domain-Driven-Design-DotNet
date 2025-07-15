namespace Wpm.SharedKernel
{
    public class Entity : IEquatable<Entity>
    {
        /*
         * The init keyword allows us to create properties that can only be initialized at the time of object creation
         * C# 9.0 (Update) */

        public Guid Id { get; init; }


        public bool Equals(Entity? other)
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

        public static bool operator ==(Entity? right, Entity Left)
        {
            return Left?.Id == right?.Id;
        }

        public static bool operator !=(Entity? right, Entity Left)
        {
            return Left?.Id != right?.Id;
        }

    }

}
