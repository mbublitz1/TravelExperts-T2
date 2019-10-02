namespace Data.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPackageImageLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Packages", "PackageImageLocation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Packages", "PackageImageLocation");
        }
    }
}
