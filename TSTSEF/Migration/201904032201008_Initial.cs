namespace TSTSEF.AgressorsMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agressors",
                c => new
                    {
                        AgressorId = c.Int(nullable: false, identity: true),
                        AgressorName = c.String(),
                    })
                .PrimaryKey(t => t.AgressorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Agressors");
        }
    }
}
