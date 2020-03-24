using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.DAL.EntityModel
{
    //We can use data annotation to specify this is a table. But EF does this work for you. 
    [Table("Person")]
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } // Ideally this can be a seperate table, for demo purpose we use only Male and Female as Gender and String to be the data type
        public IList<PersonContactInformation> PersonContactInformation { get; set; }
        public IList<PersonInterest> PersonInterest { get; set; }
    }
}
