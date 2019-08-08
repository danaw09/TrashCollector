namespace TrashColllector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedDeleteWorkerOrder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Workorders", "customer_UserId", "dbo.Customers");
            DropIndex("dbo.Workorders", new[] { "customer_UserId" });
            AddColumn("dbo.Customers", "WeeklyPickUpDayId", c => c.String());
            DropTable("dbo.Workorders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Workorders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        submittedDateTime = c.DateTime(nullable: false),
                        scheduledDateTime = c.DateTime(nullable: false),
                        TypeId = c.Int(nullable: false),
                        completionDate = c.DateTime(nullable: false),
                        customer_UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Customers", "WeeklyPickUpDayId");
            CreateIndex("dbo.Workorders", "customer_UserId");
            AddForeignKey("dbo.Workorders", "customer_UserId", "dbo.Customers", "UserId");
        }
    }
}
