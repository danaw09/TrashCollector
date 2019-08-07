namespace TrashColllector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.States", "AbbreviationShort", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.States", "AbbreviationShort");
        }
    }
}
