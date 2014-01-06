using System;
using System.Data.Entity;

namespace MvcBasedTemplate.Models
{
    public class Association
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WebAddress { get; set; }
        public DateTime CreatedOn { get; set; }
    }
    public class MVCDBContext : DbContext
    {
        public DbSet<Association> Associations { get; set; }
    }
}