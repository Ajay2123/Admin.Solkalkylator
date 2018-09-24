namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstalledPowerOrganisationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InstalledPowerOrganisations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Organisation = c.String(),
                        BaseInstalledPower = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InstalledPowerOrganisations");
        }
    }
}
