using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubVS2012Test.Domain
{
    public class PersonList : List<Person>
    {
        public static PersonList GetPeople()
        {
            PersonList people = new PersonList
            {
                new Person 
                {
                    Name = "Einstein",
                    Saying = "E=MC^2"
                },
                new Person
                {
                    Name = "Saddam",
                    Saying = "What's that whistling sound?"
                },
                new Person
                {
                    Name = "George Bush",
                    Saying = "Pass the Yaeger.  hehehehe"
                }
            };
            return people;
        }
    }
}
