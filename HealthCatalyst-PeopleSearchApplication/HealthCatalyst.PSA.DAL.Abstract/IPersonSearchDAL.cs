using HealthCatalyst.PSA.DAL.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.DAL.Abstract
{
   public interface IPersonSearchDAL
    {
        IQueryable<Person> GetPersons(); 
    }
}
