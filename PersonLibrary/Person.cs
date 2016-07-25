using System;

namespace PersonLibrary
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Equals(Person other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Equals(this.FirstName, other.FirstName) &&
                   string.Equals(this.LastName, other.LastName);
        }

        public int CompareTo(Person other)
        {
            if (other == null)
            {
                return 1;
            }

            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            var comparison = string.CompareOrdinal(this.LastName, other.LastName);

            return comparison != 0 ? comparison : string.CompareOrdinal(this.FirstName, other.FirstName);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((this.FirstName?.GetHashCode() ?? 0) * 397) ^
                       (this.LastName?.GetHashCode() ?? 0);
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}