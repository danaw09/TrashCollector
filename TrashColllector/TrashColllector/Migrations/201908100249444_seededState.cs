namespace TrashColllector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seededState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "ServicePostalCodeForm", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "ServicePostalCodeForm");
        }
    }
}
