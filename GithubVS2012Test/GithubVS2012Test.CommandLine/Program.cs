using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubVS2012Test.CommandLine
{
    class Program
    {

        /// <summary>
        /// Adding some documentation so there's something to commit.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            foreach (var person in Domain.PersonList.GetPeople())
            {
                Console.WriteLine("Person {0}: Saying: {1}", person.Name, person.Saying);
            }
            Console.Read();
        }
    }
}
