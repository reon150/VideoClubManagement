namespace VideoClubManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticleCasts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        CastId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.Casts", t => t.CastId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.ArticleId)
                .Index(t => t.CastId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        RentPerDay = c.Decimal(nullable: false, precision: 10, scale: 4),
                        RentalDays = c.Int(nullable: false),
                        LateReturnFee = c.Decimal(nullable: false, precision: 10, scale: 4),
                        ArticleTypeId = c.Int(nullable: false),
                        LanguageId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArticleTypes", t => t.ArticleTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.LanguageId, cascadeDelete: true)
                .Index(t => t.ArticleTypeId)
                .Index(t => t.LanguageId);
            
            CreateTable(
                "dbo.ArticleLendings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DueDate = c.DateTime(nullable: false, storeType: "date"),
                        ReturnDate = c.DateTime(storeType: "date"),
                        AmountPerDay = c.Decimal(nullable: false, precision: 10, scale: 4),
                        Comment = c.String(nullable: false, maxLength: 1000),
                        EmployeeId = c.Int(nullable: false),
                        ArticleId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.ArticleId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        TaxpayerIdentificationNumber = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        CreditCardNumber = c.String(nullable: false, maxLength: 16, fixedLength: true),
                        CreditLimit = c.Decimal(nullable: false, precision: 10, scale: 4),
                        LegalPersonTypeId = c.Byte(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LegalPersonTypes", t => t.LegalPersonTypeId, cascadeDelete: true)
                .Index(t => t.LegalPersonTypeId);
            
            CreateTable(
                "dbo.LegalPersonTypes",
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
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        IdentificationNumber = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        CommissionPercentage = c.Decimal(nullable: false, precision: 10, scale: 4),
                        EnteringDate = c.DateTime(nullable: false, storeType: "date"),
                        ShiftWorkId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShiftWorks", t => t.ShiftWorkId, cascadeDelete: true)
                .Index(t => t.ShiftWorkId);
            
            CreateTable(
                "dbo.ShiftWorks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                        StartHour = c.Time(nullable: false, precision: 7),
                        FinishHour = c.Time(nullable: false, precision: 7),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        ParentId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ISOCode = c.String(nullable: false, maxLength: 5, fixedLength: true),
                        Description = c.String(nullable: false, maxLength: 30),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.ISOCode, unique: true);
            
            CreateTable(
                "dbo.Casts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GenreArticles",
                c => new
                    {
                        Genre_Id = c.Int(nullable: false),
                        Article_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Article_Id })
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("dbo.Articles", t => t.Article_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Article_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticleCasts", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.ArticleCasts", "CastId", "dbo.Casts");
            DropForeignKey("dbo.Articles", "LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Genres", "ParentId", "dbo.Genres");
            DropForeignKey("dbo.GenreArticles", "Article_Id", "dbo.Articles");
            DropForeignKey("dbo.GenreArticles", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Articles", "ArticleTypeId", "dbo.ArticleTypes");
            DropForeignKey("dbo.Employees", "ShiftWorkId", "dbo.ShiftWorks");
            DropForeignKey("dbo.ArticleLendings", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Clients", "LegalPersonTypeId", "dbo.LegalPersonTypes");
            DropForeignKey("dbo.ArticleLendings", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ArticleLendings", "ArticleId", "dbo.Articles");
            DropForeignKey("dbo.ArticleCasts", "ArticleId", "dbo.Articles");
            DropIndex("dbo.GenreArticles", new[] { "Article_Id" });
            DropIndex("dbo.GenreArticles", new[] { "Genre_Id" });
            DropIndex("dbo.Languages", new[] { "ISOCode" });
            DropIndex("dbo.Genres", new[] { "ParentId" });
            DropIndex("dbo.Employees", new[] { "ShiftWorkId" });
            DropIndex("dbo.Clients", new[] { "LegalPersonTypeId" });
            DropIndex("dbo.ArticleLendings", new[] { "ClientId" });
            DropIndex("dbo.ArticleLendings", new[] { "ArticleId" });
            DropIndex("dbo.ArticleLendings", new[] { "EmployeeId" });
            DropIndex("dbo.Articles", new[] { "LanguageId" });
            DropIndex("dbo.Articles", new[] { "ArticleTypeId" });
            DropIndex("dbo.ArticleCasts", new[] { "RoleId" });
            DropIndex("dbo.ArticleCasts", new[] { "CastId" });
            DropIndex("dbo.ArticleCasts", new[] { "ArticleId" });
            DropTable("dbo.GenreArticles");
            DropTable("dbo.Roles");
            DropTable("dbo.Casts");
            DropTable("dbo.Languages");
            DropTable("dbo.Genres");
            DropTable("dbo.ArticleTypes");
            DropTable("dbo.ShiftWorks");
            DropTable("dbo.Employees");
            DropTable("dbo.LegalPersonTypes");
            DropTable("dbo.Clients");
            DropTable("dbo.ArticleLendings");
            DropTable("dbo.Articles");
            DropTable("dbo.ArticleCasts");
        }
    }
}
