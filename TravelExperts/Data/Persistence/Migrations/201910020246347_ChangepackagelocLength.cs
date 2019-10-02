namespace Data.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangepackagelocLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Packages", "PackageImageLocation", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Packages", "PackageImageLocation", c => c.String());
        }
    }
}
