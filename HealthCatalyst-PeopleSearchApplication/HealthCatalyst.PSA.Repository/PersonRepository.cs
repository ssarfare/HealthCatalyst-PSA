using HealthCatalyst.PSA.DAL.Abstract;
using HealthCatalyst.PSA.DAL.EntityModel;
using HealthCatalyst.PSA.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.Repository.Concrete
{
    public class PersonRepository: IPersonRepository
    {
        private readonly IPersonSearchDAL personSearchDAL;
        public PersonRepository(IPersonSearchDAL personSearchDAL) {
            this.personSearchDAL = personSearchDAL;
        }

        public List<Person> SearchPerson(string queryString)
        {
            var persons = personSearchDAL.GetPersons();
            return (from person in persons
            where person.FirstName.ToLower().Contains(queryString.ToLower())
            || person.LastName.ToLower().Contains(queryString.ToLower())
            || String.IsNullOrEmpty(queryString)
            orderby person.FirstName 
            select person).ToList();
        }
    }
}
