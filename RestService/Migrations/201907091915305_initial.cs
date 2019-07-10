namespace RestService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MainRequest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Insert_Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Request",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Insert_Time = c.DateTime(nullable: false),
                        MainRequestId = c.Int(nullable: false),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MainRequest", t => t.MainRequestId, cascadeDelete: true)
                .Index(t => t.MainRequestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Request", "MainRequestId", "dbo.MainRequest");
            DropIndex("dbo.Request", new[] { "MainRequestId" });
            DropTable("dbo.Request");
            DropTable("dbo.MainRequest");
        }
    }
}
