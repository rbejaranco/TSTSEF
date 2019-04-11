namespace TSTSEF.IFMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class IFConf : DbMigrationsConfiguration<TSTSEF.Models.ApplicationDbContext>
    {
        public IFConf()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"IFMigrations";
        }

        protected override void Seed(TSTSEF.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
