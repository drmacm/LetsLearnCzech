namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableEnums : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Words", "ForeignGender", c => c.Int());
            AlterColumn("dbo.Words", "LocalGender", c => c.Int());
            AlterColumn("dbo.Words", "Case", c => c.Int());
            AlterColumn("dbo.Words", "Conjugation", c => c.Int());
            AlterColumn("dbo.Words", "Aspect", c => c.Int());
            AlterColumn("dbo.Words", "Person", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Words", "Person", c => c.Int(nullable: false));
            AlterColumn("dbo.Words", "Aspect", c => c.Int(nullable: false));
            AlterColumn("dbo.Words", "Conjugation", c => c.Int(nullable: false));
            AlterColumn("dbo.Words", "Case", c => c.Int(nullable: false));
            AlterColumn("dbo.Words", "LocalGender", c => c.Int(nullable: false));
            AlterColumn("dbo.Words", "ForeignGender", c => c.Int(nullable: false));
        }
    }
}
