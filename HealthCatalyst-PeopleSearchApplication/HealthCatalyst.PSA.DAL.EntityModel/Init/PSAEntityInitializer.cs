using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.DAL.EntityModel.Init
{
    /// <summary>
    /// This class is used to seed data to the database created in your localdb 
    /// </summary>
    public class PSAEntityInitializer : CreateDatabaseIfNotExists<PSAEntities>
    {
        protected override void Seed(PSAEntities context)
        {
            IList<Person> seedPersonList = new List<Person>();
            Person person = new Person() { FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1987, 9, 10), Gender = "Male" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "9284 Lake View Ave,Brooklyn,NY 11201", PhoneNumber = "(299) 556-1408" },
                new PersonContactInformation() { Address = "835 Madison St.Augusta,GA 30906", PhoneNumber = "(908) 943-4245" }
            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest="Swimming" },
                new PersonInterest() { Interest = "Badminton" },
                new PersonInterest() { Interest = "Basketball" } };
            
            seedPersonList.Add(person);


            person = new Person() { FirstName = "Julia", LastName = "Cooper", DateOfBirth = new DateTime(1995, 10, 12), Gender = "Female" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "7019 Morris Avenue,North Kingstown, RI 02852", PhoneNumber = "(498) 210-8219" }            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest="Singing" },
                new PersonInterest() { Interest = "Cycling and Mountain Biking" },
                new PersonInterest() { Interest = "Coaching and Mentoring" },
                new PersonInterest() { Interest = "Camping" } };

            seedPersonList.Add(person);


            person = new Person() { FirstName = "Robert", LastName = "Ward", DateOfBirth = new DateTime(1991, 05, 03), Gender = "Male" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "231 Trout Rd.Far Rockaway, NY 11691", PhoneNumber = "(521) 284-4658" },
                new PersonContactInformation() { Address = "96 Pulaski St.Redondo Beach, CA 90278", PhoneNumber = "(521) 985-1448" },
            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest="Astronomy" },
                new PersonInterest() { Interest = "Collecting" },
                new PersonInterest() { Interest = "Meditation" }
            };

            seedPersonList.Add(person);


            person = new Person() { FirstName = "Beverly", LastName = "Russell", DateOfBirth = new DateTime(2000, 01, 02), Gender = "Female" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "9956 Hartford St.Solon, OH 44139", PhoneNumber = "(854) 655-1252" },
            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest="Scotch Tasting" },
                new PersonInterest() { Interest = "Reading" },
                new PersonInterest() { Interest = "Traveling" }
            };

            seedPersonList.Add(person);

            person = new Person() { FirstName = "Christina", LastName = "Young", DateOfBirth = new DateTime(1989, 03, 19), Gender = "Male" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "42 Shore Lane Bristol, CT 06010", PhoneNumber = "(908) 778-5651" },
            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest = "Mosaic Art" }
            };

            seedPersonList.Add(person);

            person = new Person() { FirstName = "Heather", LastName = "Edwards", DateOfBirth = new DateTime(1998, 12, 31), Gender = "Male" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "811 S. Eagle Lane Olive Branch, MS 38654", PhoneNumber = "(756) 325-6554" },
                new PersonContactInformation() { Address = "7712 Maple Ave.North Bergen, NJ 07047", PhoneNumber = "(302) 111-8565" }
            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest="Gold Panning" },
                new PersonInterest() { Interest = "Classic Car Restoration" },
                new PersonInterest() { Interest = "Skateboarding and BMX" },
                new PersonInterest() { Interest = "Camping" },
                new PersonInterest() { Interest = "Boxing" },
                new PersonInterest() { Interest = "Origami" },
            };

            seedPersonList.Add(person);

            person = new Person() { FirstName = "Aaron", LastName = "Howard", DateOfBirth = new DateTime(1995, 03, 31), Gender = "Male" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "713 Wakehurst St.Falls Church, VA 22041", PhoneNumber = "(980) 325-5364" }
            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest="Photography" },
                new PersonInterest() { Interest = "Auto Racing" },
                new PersonInterest() { Interest = "Investing" },
                new PersonInterest() { Interest = "Fishing" }
            };

            seedPersonList.Add(person);

            person = new Person() { FirstName = "Brynlee", LastName = "Potts", DateOfBirth = new DateTime(1998, 05, 21), Gender = "Female" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "245 South Bank Dr.West Chester, PA 19380", PhoneNumber = "(777) 658-1535" }
            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest="Wine Tasting" },
                new PersonInterest() { Interest = "Jewelry Making" },
                new PersonInterest() { Interest = "Skiing and Snowboarding" },
            };

            seedPersonList.Add(person);


            person = new Person() { FirstName = "Aydin ", LastName = "Joseph", DateOfBirth = new DateTime(1991, 03, 19), Gender = "Male" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "7 Sugar Court Flint, MI 48504", PhoneNumber = "(856) 135-7598" }
            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest="Astronomy" },
                new PersonInterest() { Interest = "Bowling" },
                new PersonInterest() { Interest = "Cycling and Mountain Biking" },
                new PersonInterest() { Interest = "Rock Sports" },
                new PersonInterest() { Interest = "Surfing" }
            };

            seedPersonList.Add(person);

            person = new Person() { FirstName = "Jamar", LastName = "Chapman", DateOfBirth = new DateTime(2001, 01, 01), Gender = "Male" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "30 Morris Rd. Bardstown, KY 40004", PhoneNumber = "(999) 268-7598" }
            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest = "Cycling and Mountain Biking" },
                new PersonInterest() { Interest = "Rock Sports" },
                new PersonInterest() { Interest = "Surfing" }
            };

            seedPersonList.Add(person);

            person = new Person() { FirstName = "Clarissa", LastName = "Byrd", DateOfBirth = new DateTime(1994, 06, 25), Gender = "Female" };
            person.PersonContactInformation = new List<PersonContactInformation>
            {
                new PersonContactInformation() { Address = "28 Ann Ave. North Wales, PA 19454", PhoneNumber = "(986) 123-7584" }
            };

            person.PersonInterest = new List<PersonInterest>{
                new PersonInterest() { Interest = "Rebounding" },
                new PersonInterest() { Interest = "Collecting" },
                new PersonInterest() { Interest = "Poker and Cards" }
            };

            seedPersonList.Add(person);

            context.Person.AddRange(seedPersonList);

            base.Seed(context);
        }
    }
}