using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcPeople.Models
{
    public class Person
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string firstName { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string lastName { get; set; }
        [Range(1, 100)]
        public int age { get; set; }

        public class PeopleDBContext : DbContext
        {
            public DbSet<Person> People { get; set; }
        }
    }
}