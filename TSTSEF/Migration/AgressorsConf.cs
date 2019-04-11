namespace TSTSEF.AgressorsMigration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class AgressorsConf : DbMigrationsConfiguration<TSTSEF.Models.AgressorsDb>
    {
        public AgressorsConf()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"AgressorsMigration";
        }

        protected override void Seed(TSTSEF.Models.AgressorsDb context)
        {
            context.Agressors.AddOrUpdate(new Models.Agressor() { AgressorId=1, AgressorName="Pikachu" } );   
           
        }

    }
}
