namespace XBLR.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        pid = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.pid)
                .Index(t => t.pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "pid", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "pid" });
            DropTable("dbo.Categories");
        }
    }
}
