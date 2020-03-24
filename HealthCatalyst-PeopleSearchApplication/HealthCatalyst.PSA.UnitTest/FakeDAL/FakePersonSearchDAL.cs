using HealthCatalyst.PSA.DAL.Abstract;
using HealthCatalyst.PSA.DAL.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.UnitTests.FakeDAL
{
    /// <summary>
    /// This class is used to Mock the Database for Unit Testing.
    /// </summary>
    public class FakePersonSearchDAL : IPersonSearchDAL
    {
        public IQueryable<Person> GetPersons()
        {
            List<Person> people = new List<Person>();
            Person person = new Person() { FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1994, 10, 12), Gender = "Male" };
            person.PersonContactInformation = new List<PersonContactInformation>() { new PersonContactInformation() { Address = "945 Park Avenue, North Carolina 2912", PhoneNumber = "(985)-598-9865" } };
            person.PersonInterest = new List<PersonInterest>() { new PersonInterest() { Interest = "Cricket" } };
            people.Add(person);
            return people.AsQueryable();
        }
    }
}
