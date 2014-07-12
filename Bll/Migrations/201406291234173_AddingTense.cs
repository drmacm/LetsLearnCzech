namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTense : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Words", "Tense", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Words", "Tense");
        }
    }
}
