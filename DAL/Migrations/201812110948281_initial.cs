namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cookers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsTaken = c.Boolean(nullable: false),
                        IsReady = c.Boolean(nullable: false),
                        Time = c.DateTime(nullable: false),
                        CookerId = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cookers", t => t.CookerId, cascadeDelete: true)
                .Index(t => t.CookerId);
            
            CreateTable(
                "dbo.Sushis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sushis", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CookerId", "dbo.Cookers");
            DropIndex("dbo.Sushis", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "CookerId" });
            DropTable("dbo.Sushis");
            DropTable("dbo.Orders");
            DropTable("dbo.Cookers");
        }
    }
}
