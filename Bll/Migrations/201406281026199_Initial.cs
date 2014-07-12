namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ForeignWord = c.String(nullable: false),
                        LocalWord = c.String(),
                        DateModified = c.DateTime(),
                        IsProcessed = c.Boolean(nullable: false),
                        WordType = c.Int(nullable: false),
                        ForeignGender = c.Int(nullable: false),
                        LocalGender = c.Int(nullable: false),
                        Case = c.Int(nullable: false),
                        Conjugation = c.Int(nullable: false),
                        Aspect = c.Int(nullable: false),
                        Person = c.Int(nullable: false),
                        Creator_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Creator_UserId)
                .Index(t => t.Creator_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Words", "Creator_UserId", "dbo.Users");
            DropIndex("dbo.Words", new[] { "Creator_UserId" });
            DropTable("dbo.Words");
            DropTable("dbo.Users");
        }
    }
}
