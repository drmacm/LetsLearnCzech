namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingIsSynhronized : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Words", "IsSynhronized", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Words", "IsSynhronized");
        }
    }
}
