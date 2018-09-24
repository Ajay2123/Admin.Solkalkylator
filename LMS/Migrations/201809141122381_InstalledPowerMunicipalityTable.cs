namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstalledPowerMunicipalityTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InstalledPowerMunicipalities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Kommun = c.String(),
                        BaseInstalledPower = c.Int(nullable: false),
                        Inhabitants = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InstalledPowerMunicipalities");
        }
    }
}
