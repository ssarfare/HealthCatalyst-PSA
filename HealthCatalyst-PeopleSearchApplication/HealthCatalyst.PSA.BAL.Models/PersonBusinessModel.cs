using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.BAL.Models
{
    public class PersonBusinessModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Age { get { return DateTime.Today.Year - DateOfBirth.Year;}} // assuming age will be an integer value and Date of Birth is provided
        public IList<PersonContactInformationBusinessModel> PersonContactInformationBusinessModels { get; set; }
        public IList<PersonInterestBusinessModel> PersonInterestBusinessModels { get; set; }
    }
}
