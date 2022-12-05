using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DummyBazaarOzi.Models
{
    public partial class DummyBazaarOziModel : DbContext
    {
        internal object manager;

        public DummyBazaarOziModel()
            : base("name=DummyBazaarOziModel")
        {
        }
        public DbSet<Manager> managers { get; set; }
        public virtual DbSet<ManagerType>managerTypes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
