using HealthCatalyst.PSA.DAL.Abstract;
using HealthCatalyst.PSA.DAL.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.DAL.Concrete
{
    public class PersonSearchDAL : IPersonSearchDAL
    {
        public IQueryable<Person> GetPersons()
        {
            PSAEntities context = new PSAEntities();
            return context.Person.Include(x => x.PersonContactInformation).Include(x => x.PersonInterest);
        }
    }
}
