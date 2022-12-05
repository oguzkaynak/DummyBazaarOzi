namespace DummyBazaarOzi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DummyBazaarOzi.Models.DummyBazaarOziModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DummyBazaarOzi.Models.DummyBazaarOziModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.managerTypes.AddOrUpdate(n => n.Id, new Models.ManagerType() { Id = 1, Name = "Admin" });
            context.managerTypes.AddOrUpdate(n => n.Id, new Models.ManagerType() { Id = 2, Name = "Moderatör" });
            context.managers.AddOrUpdate(n => n.ID, new Models.Manager() { ID = 1, Name = "Oðuzhan", Surname = "Kaynak", Mail = "oguz-kaynak@hotmail.com", manager_typeID =1, Password = "1234", UserName = "Ozi", IsActive =true });
        }
    }
}
