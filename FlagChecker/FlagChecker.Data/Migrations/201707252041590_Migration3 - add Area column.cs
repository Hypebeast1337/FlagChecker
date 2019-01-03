namespace FlagChecker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3addAreacolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "Area", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countries", "Area");
        }
    }
}
