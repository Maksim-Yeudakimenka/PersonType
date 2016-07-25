using System.Collections.Generic;
using System.Linq;
using PersonLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person { FirstName = "Alex", LastName = "Ivanov" };
            var p2 = new Person { FirstName = "Alex", LastName = "Ivanov" };

            var equalPeople = p1.Equals(p2); // Uses Person.Equals

            // Use Person.GetHashCode and Person.Equals on add
            var people1 = new HashSet<Person> { p1, p2, new Person { FirstName = "Maksim", LastName = "Petrov" } };
            var people2 = new HashSet<Person> { new Person { FirstName = "Dmitriy", LastName = "Sokolov" }, p2 };

            people1.ToList().Sort(); // Uses Person.CompareTo
        }
    }
}