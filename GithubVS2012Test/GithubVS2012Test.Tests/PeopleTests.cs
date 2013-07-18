using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GithubVS2012Test.Tests
{
    [TestClass]
    public class PeopleTests
    {
        [TestMethod]
        public void GetEinsteinAndCompareSaying()
        {
            var person = Domain.PersonList.GetPeople().FirstOrDefault(p => p.Name.Equals("Einstein"));
            Assert.AreEqual(person.Saying, "E=MC^2");
        }
    }
}
