namespace FlagChecker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration5addsharetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shares",
                c => new
                    {
                        Uid = c.String(nullable: false, maxLength: 128),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Uid);
            
            AddColumn("dbo.Countries", "Share_Uid", c => c.String(maxLength: 128));
            CreateIndex("dbo.Countries", "Share_Uid");
            AddForeignKey("dbo.Countries", "Share_Uid", "dbo.Shares", "Uid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Countries", "Share_Uid", "dbo.Shares");
            DropIndex("dbo.Countries", new[] { "Share_Uid" });
            DropColumn("dbo.Countries", "Share_Uid");
            DropTable("dbo.Shares");
        }
    }
}
