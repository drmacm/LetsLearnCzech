namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingWordState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Words", "WordState", c => c.Int(nullable: false));
            DropColumn("dbo.Words", "IsSynhronized");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Words", "IsSynhronized", c => c.Boolean(nullable: false));
            DropColumn("dbo.Words", "WordState");
        }
    }
}
