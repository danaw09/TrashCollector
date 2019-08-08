namespace TrashColllector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingWeekDayModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Postalcodes", "cityId", "dbo.Cities");
            DropIndex("dbo.Postalcodes", new[] { "cityId" });
            DropPrimaryKey("dbo.Employees");
            DropPrimaryKey("dbo.Postalcodes");
            CreateTable(
                "dbo.WeekDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AbbreviationShort = c.String(nullable: false),
                        AbbreviationMedium = c.String(nullable: false),
                        AreOperating = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Employees", "ServicePostalCodeId", c => c.Int());
            AddColumn("dbo.Employees", "ServicePostalCode_CityId", c => c.Int());
            AddColumn("dbo.Postalcodes", "Code", c => c.String());
            AddColumn("dbo.Postalcodes", "City_Id", c => c.Int());
            AlterColumn("dbo.Cities", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "FirstName", c => c.String());
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Postalcodes", "CityId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.States", "Name", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Employees", "UserId");
            AddPrimaryKey("dbo.Postalcodes", "CityId");
            CreateIndex("dbo.Addresses", "PostalCodeId");
            CreateIndex("dbo.Postalcodes", "City_Id");
            CreateIndex("dbo.Cities", "StateId");
            CreateIndex("dbo.Employees", "ServicePostalCode_CityId");
            AddForeignKey("dbo.Cities", "StateId", "dbo.States", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "PostalCodeId", "dbo.Postalcodes", "CityId", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "ServicePostalCode_CityId", "dbo.Postalcodes", "CityId");
            AddForeignKey("dbo.Postalcodes", "City_Id", "dbo.Cities", "Id");
            DropColumn("dbo.Addresses", "Postalcode");
            DropColumn("dbo.Cities", "state");
            DropColumn("dbo.Employees", "Id");
            DropColumn("dbo.Employees", "postalCode");
            DropColumn("dbo.Postalcodes", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Postalcodes", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Employees", "postalCode", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Cities", "state", c => c.String());
            AddColumn("dbo.Addresses", "Postalcode", c => c.Int(nullable: false));
            DropForeignKey("dbo.Postalcodes", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Employees", "ServicePostalCode_CityId", "dbo.Postalcodes");
            DropForeignKey("dbo.Addresses", "PostalCodeId", "dbo.Postalcodes");
            DropForeignKey("dbo.Cities", "StateId", "dbo.States");
            DropIndex("dbo.Employees", new[] { "ServicePostalCode_CityId" });
            DropIndex("dbo.Cities", new[] { "StateId" });
            DropIndex("dbo.Postalcodes", new[] { "City_Id" });
            DropIndex("dbo.Addresses", new[] { "PostalCodeId" });
            DropPrimaryKey("dbo.Postalcodes");
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.States", "Name", c => c.String());
            AlterColumn("dbo.Postalcodes", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "LastName", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "FirstName", c => c.Int(nullable: false));
            AlterColumn("dbo.Cities", "Name", c => c.String());
            DropColumn("dbo.Postalcodes", "City_Id");
            DropColumn("dbo.Postalcodes", "Code");
            DropColumn("dbo.Employees", "ServicePostalCode_CityId");
            DropColumn("dbo.Employees", "ServicePostalCodeId");
            DropColumn("dbo.Employees", "UserId");
            DropTable("dbo.WeekDays");
            AddPrimaryKey("dbo.Postalcodes", "Id");
            AddPrimaryKey("dbo.Employees", "Id");
            CreateIndex("dbo.Postalcodes", "cityId");
            AddForeignKey("dbo.Postalcodes", "cityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
    }
}
