using HealthCatalyst.PSA.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.BAL.Abstract
{
    public interface IPersonSearchManager
    {
        List<PersonBusinessModel> SearchPerson(String queryString);
    }
}
