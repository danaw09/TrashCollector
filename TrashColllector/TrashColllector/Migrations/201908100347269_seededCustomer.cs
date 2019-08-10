namespace TrashColllector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seededCustomer : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Employees");
            AddColumn("dbo.Employees", "UserName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Employees", "UserId", c => c.String());
            AddPrimaryKey("dbo.Employees", "UserName");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.Employees", "UserId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Employees", "UserName");
            AddPrimaryKey("dbo.Employees", "UserId");
        }
    }
}
