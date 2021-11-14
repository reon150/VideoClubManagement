namespace VideoClubManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdentificationNumber = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 20),
                        UserRoleId = c.Byte(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserRoles", t => t.UserRoleId, cascadeDelete: true)
                .Index(t => t.IdentificationNumber, unique: true)
                .Index(t => t.UserName, unique: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.UserRoleId);
            
            CreateIndex("dbo.Clients", "TaxpayerIdentificationNumber", unique: true);
            CreateIndex("dbo.Clients", "CreditCardNumber", unique: true);
            CreateIndex("dbo.Employees", "IdentificationNumber", unique: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserRoleId", "dbo.UserRoles");
            DropIndex("dbo.Users", new[] { "UserRoleId" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "UserName" });
            DropIndex("dbo.Users", new[] { "IdentificationNumber" });
            DropIndex("dbo.Employees", new[] { "IdentificationNumber" });
            DropIndex("dbo.Clients", new[] { "CreditCardNumber" });
            DropIndex("dbo.Clients", new[] { "TaxpayerIdentificationNumber" });
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
        }
    }
}
