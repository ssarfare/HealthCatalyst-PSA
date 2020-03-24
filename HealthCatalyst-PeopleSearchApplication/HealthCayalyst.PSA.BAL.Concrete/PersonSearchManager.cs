using HealthCatalyst.PSA.BAL.Abstract;
using HealthCatalyst.PSA.BAL.Models;
using HealthCatalyst.PSA.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCayalyst.PSA.BAL.Concrete
{
    public class PersonSearchManager : IPersonSearchManager
    {
        private readonly IPersonRepository personRepository;
        public PersonSearchManager(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        /// <summary>
        /// This method retries data in form of entity model from the repository based on the input query string and
        /// wraps it around a wrapper class and performs any neccessary business calculations.
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns>List of PersonBusinessModel</returns>
        public List<PersonBusinessModel> SearchPerson(String queryString)
        {
            var data = personRepository.SearchPerson(queryString);
            List<PersonBusinessModel> personBusinessModels = new List<PersonBusinessModel>();

            foreach (var person in data) {
                PersonBusinessModel personBusinessModel = new PersonBusinessModel();
                personBusinessModel.FirstName = person.FirstName;
                personBusinessModel.LastName= person.LastName;
                personBusinessModel.DateOfBirth = person.DateOfBirth;
                personBusinessModel.Gender= person.Gender;
                personBusinessModel.PersonInterestBusinessModels = new List<PersonInterestBusinessModel>();
                foreach (var interest in person.PersonInterest) {
                    personBusinessModel.PersonInterestBusinessModels.Add(new PersonInterestBusinessModel() { Interest = interest.Interest });
                }
                personBusinessModel.PersonContactInformationBusinessModels = new List<PersonContactInformationBusinessModel>();
                foreach (var contact in person.PersonContactInformation)
                {
                    personBusinessModel.PersonContactInformationBusinessModels.Add(new PersonContactInformationBusinessModel() { Address=contact.Address, PhoneNumber=contact.PhoneNumber});
                }
                personBusinessModels.Add(personBusinessModel);
            }
            return personBusinessModels;
        }
        }
    }
