using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpm.Management.Domain
{
    public class Entity : IEquatable<Entity>
    {
        public Guid Id { set; get; }


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
