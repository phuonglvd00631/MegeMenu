namespace MegaMenu.Migrations
{
    using MegaMenu.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MegaMenu.Models.MegaMenuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MegaMenu.Models.MegaMenuDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Database.ExecuteSqlCommand("DELETE FROM Categories");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Categories', RESEED, 0)");
            IList<Categories> categories = new List<Categories>();
            categories.Add(new Categories { Id = 1, Name = "Laptop", ParentId = 0 });
            categories.Add(new Categories { Id = 2 , Name = "Mobile", ParentId = 4 });
            categories.Add(new Categories { Id = 3, Name = "Fashion", ParentId = 0 });
            categories.Add(new Categories { Id = 4, Name = "Apple", ParentId = 0 });
            categories.Add(new Categories { Id = 5, Name = "IPhone", ParentId = 2 });
            categories.Add(new Categories { Id = 6, Name = "HP", ParentId = 1 });
            categories.Add(new Categories { Id = 7, Name = "Lenovo", ParentId = 1 });
            categories.Add(new Categories { Id = 8, Name = "Iphone 12", ParentId = 5 });
            categories.Add(new Categories { Id = 9, Name = "Iphone 12 Pro Max", ParentId =  5});
            categories.Add(new Categories { Id = 10, Name = "Bad Habbit", ParentId = 3 });
            categories.Add(new Categories { Id = 11, Name = "Zara", ParentId = 3 });
            categories.Add(new Categories { Id = 12, Name = "Macbook", ParentId = 4 });
            categories.Add(new Categories { Id = 13, Name = "IMac", ParentId = 4 });

            context.Categories.AddRange(categories);
            base.Seed(context);
        }
    }
}
