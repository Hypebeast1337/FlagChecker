namespace FlagChecker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration4AddENandPLnamingforcountries : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "NameEn", c => c.String());
            AddColumn("dbo.Countries", "NamePl", c => c.String());
            DropColumn("dbo.Countries", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Name", c => c.String());
            DropColumn("dbo.Countries", "NamePl");
            DropColumn("dbo.Countries", "NameEn");
        }
    }
}
