using HealthCatalyst.PSA.BAL.Abstract;
using HealthCatalyst.PSA.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HealthCatalyst.PSA.WebAPI.Controllers
{
    public class PersonSearchController : ApiController
    {
        private readonly IPersonSearchManager personSearchManager;

        public PersonSearchController(IPersonSearchManager personSearchManager)
        {
            this.personSearchManager = personSearchManager;
        }

        /// <summary>
        /// Http Get method that returns a list of all people when the query string is empty
        /// or returns the records that contain the input query string.
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns>List of People</returns>
        [HttpGet]
        public List<PersonBusinessModel> SearchPeople(string queryString){
            return personSearchManager.SearchPerson(queryString);
        }
    }
}
