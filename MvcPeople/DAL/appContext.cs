using MvcPeople.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MvcPeople.DAL
{
    public class appContext : DbContext
    {
        public appContext() : base("appContext")
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Interest> Interests { get; set; }

    }
}