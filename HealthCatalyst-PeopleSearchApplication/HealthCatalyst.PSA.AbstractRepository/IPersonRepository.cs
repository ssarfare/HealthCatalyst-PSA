using HealthCatalyst.PSA.DAL.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.Repository.Abstract
{
    public interface IPersonRepository
    {
         List<Person> SearchPerson(string queryString);
    }
}
