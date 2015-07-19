using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcPeople.Models
{
    public enum PossibleInterest{
        Skiing, Hiking, Mountain_Biking
    }
    public class Interest
    {
        public int InterestID { get; set; }
        public int PersonID { get; set; }
        public PossibleInterest PossibleInterest { get; set; }

        public virtual Person Person { get; set; }
    }

    /*public class InterestsDBContext : DbContext
    {
        public DbSet<Interest> Interests { get; set; }

        public System.Data.Entity.DbSet<MvcPeople.Models.Person> People { get; set; }
    }*/
}