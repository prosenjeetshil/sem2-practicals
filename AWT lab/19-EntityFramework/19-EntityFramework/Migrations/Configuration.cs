namespace _19_EntityFramework.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using _19_EntityFramework.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<_19_EntityFramework.Models.RecordContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_19_EntityFramework.Models.RecordContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var students = new List<Student>
            {
                new Student { Name="Prosenjeet", Email="prosenjeet@example.com", Course="Java", Contact="+25-258628" },
                new Student { Name="Mriganka", Email="mriganka@example.com", Course=".NET", Contact="+25-258694" },
                new Student { Name="Soumen", Email="soumen@example.com", Course="Java", Contact="+25-258999" },
                new Student { Name="Rishabh", Email="rishabh@example.com", Course="Linux", Contact="+25-258111" },
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}
