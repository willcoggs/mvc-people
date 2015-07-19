using MvcPeople.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPeople.DAL
{
    public class appInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<appContext>
    {
        protected override void Seed(appContext context)
        {
            var ppl = new List<Person>
            {
                new Person
                {
                    firstName = "Will",
                    lastName = "Cogguillo",
                    age = 23
                },
                new Person
                {
                    firstName = "Hi?",
                    lastName = "Hello",
                    age = 99
                }
            };

            ppl.ForEach(s => context.People.Add(s));
            context.SaveChanges();
            var interests = new List<Interest>
             {
                 new Interest{PersonID=1,PossibleInterest=PossibleInterest.Skiing},
                 new Interest{PersonID=1,PossibleInterest=PossibleInterest.Mountain_Biking}
             };
        }
    }
}