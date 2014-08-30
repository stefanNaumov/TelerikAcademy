namespace UniversitySystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<UniversitySystem.Data.UniversitySystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "UniversitySystem.Data.UniversitySystemDbContext";
        }

        protected override void Seed(UniversitySystem.Data.UniversitySystemDbContext context)
        {
           
        }
    }
}
