using System;
using HealthCatalyst.PSA.BAL.Abstract;
using HealthCatalyst.PSA.DAL.Abstract;
using HealthCatalyst.PSA.DAL.Concrete;
using HealthCatalyst.PSA.Repository.Concrete;
using HealthCatalyst.PSA.Repository.Abstract;
using HealthCatalyst.PSA.UnitTests.FakeDAL;
using HealthCatalyst.PSA.WebAPI.Controllers;
using HealthCayalyst.PSA.BAL.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealthCatalyst.PSA.UnitTest
{
    /// <summary>
    /// This class contains test cases for testing the API.
    /// </summary>
    [TestClass]
    public class PersonSearchTest
    {
        //Arrange
        static IPersonSearchDAL personSearchDAL = new FakePersonSearchDAL();
        static IPersonRepository personRepository = new PersonRepository(personSearchDAL);
        static IPersonSearchManager personSearchManager = new PersonSearchManager(personRepository);
        static PersonSearchController personSearchController = new PersonSearchController(personSearchManager);

        [TestMethod]
        public void PersonSearch_NoMatch()
        {
            //Arrange
            string queryString = "xyz";

            //Act 
            var result=personSearchController.SearchPeople(queryString);

            //Assert
            Assert.AreEqual(0, result.Count);

        }

        [TestMethod]
        public void PersonSearch_Match()
        {
            //Arrange
            string queryString = "j";

            //Act 
            var result = personSearchController.SearchPeople(queryString);

            //Assert
            Assert.AreEqual(true, result.Count>0 && result[0].FirstName.ToLower().Contains(queryString.ToLower()));

        }

        [TestMethod]
        public void PersonSearch_AgeTest()
        {
            //Arrange
            string queryString = "j";

            //Act 
            var result = personSearchController.SearchPeople(queryString);

            //Assert
            Assert.AreEqual(26,result[0].Age);

        }

        [TestMethod]
        public void PersonSearch_RetriveAllData()
        {
            //Arrange
            string queryString = "";

            //Act 
            var result = personSearchController.SearchPeople(queryString);

            //Assert
            Assert.AreEqual(1, result.Count);

        }

    }
}
