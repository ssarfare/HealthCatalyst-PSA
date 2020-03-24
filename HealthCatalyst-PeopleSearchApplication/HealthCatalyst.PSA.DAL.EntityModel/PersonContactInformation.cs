using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.DAL.EntityModel
{
   public class PersonContactInformation
    {
        public int PersonContactInformationId { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
       
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
    }
}
