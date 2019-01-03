namespace FlagChecker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2addCodecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countries", "Code");
        }
    }
}
