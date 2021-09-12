using System;
using System.Diagnostics.CodeAnalysis;

namespace Stocks.Domain.Shared.Entities
{
    /*
     * This Entity only extends, no a instance
     * Because that will be abstract class
     */
    public abstract class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        /*
         * Closed to modification -> private
         * Id should setted by constructor
         */
        public Guid Id { get; private set; }

        public bool Equals([AllowNull] Entity other)
        {
            return (Id == other.Id);
        }
    }
}
