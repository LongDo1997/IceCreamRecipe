namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Author = c.String(maxLength: 100),
                        Description = c.String(storeType: "ntext"),
                        Price = c.Double(nullable: false),
                        ImageList = c.String(unicode: false, storeType: "text"),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        UserModifyId = c.Int(),
                        UserCreatedId = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Budget",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Balance = c.Double(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserAccount", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserAccount",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(storeType: "ntext"),
                        Email = c.String(maxLength: 100),
                        PhoneNumber = c.String(maxLength: 100),
                        Password = c.String(maxLength: 100, unicode: false),
                        Type = c.Byte(nullable: false),
                        BudgetId = c.Int(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        UserModifyId = c.Int(),
                        UserCreatedId = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true)
                .Index(t => t.PhoneNumber, unique: true);
            
            CreateTable(
                "dbo.FeedBack",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, storeType: "ntext"),
                        Star = c.Byte(),
                        ImageList = c.String(),
                        BookId = c.Int(),
                        RecipeId = c.Int(),
                        UserAccountId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        UserModifyId = c.Int(),
                        UserCreatedId = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAccount", t => t.UserAccountId, cascadeDelete: true)
                .Index(t => t.UserAccountId);
            
            CreateTable(
                "dbo.OrderHistory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 200),
                        Cost = c.Double(nullable: false),
                        PayingOption = c.Byte(nullable: false),
                        Note = c.String(nullable: false, storeType: "ntext"),
                        Type = c.Byte(),
                        OrderId = c.Int(),
                        UserAccountId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        UserModifyId = c.Int(),
                        UserCreatedId = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAccount", t => t.UserAccountId, cascadeDelete: true)
                .Index(t => t.UserAccountId);
            
            CreateTable(
                "dbo.OrderHistoryDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ImageList = c.String(unicode: false, storeType: "text"),
                        OrderHistoryId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderHistory", t => t.OrderHistoryId, cascadeDelete: true)
                .Index(t => t.OrderHistoryId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 200),
                        Cost = c.Double(nullable: false),
                        PayingOption = c.Byte(nullable: false),
                        Note = c.String(nullable: false, storeType: "ntext"),
                        Type = c.Byte(),
                        UserAccountId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        UserModifyId = c.Int(),
                        UserCreatedId = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAccount", t => t.UserAccountId, cascadeDelete: true)
                .Index(t => t.UserAccountId);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ImageList = c.String(unicode: false, storeType: "text"),
                        OrderId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Flavour",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(storeType: "ntext"),
                        ImageList = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        UserModifyId = c.Int(),
                        UserCreatedId = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(nullable: false, maxLength: 100, unicode: false),
                        FilePath = c.String(unicode: false, storeType: "text"),
                        OrgFileName = c.String(maxLength: 100, unicode: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        UserModifyId = c.Int(),
                        UserCreatedId = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RecipeFlavour",
                c => new
                    {
                        RecipeId = c.Int(nullable: false),
                        FlavourId = c.Int(nullable: false),
                        Id = c.Int(nullable: false, identity: true),
                        unit = c.String(maxLength: 10),
                        Description = c.String(storeType: "ntext"),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        UserModifyId = c.Int(),
                        UserCreatedId = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => new { t.RecipeId, t.FlavourId })
                .ForeignKey("dbo.Flavour", t => t.FlavourId, cascadeDelete: true)
                .ForeignKey("dbo.Recipe", t => t.RecipeId, cascadeDelete: true)
                .Index(t => t.RecipeId)
                .Index(t => t.FlavourId);
            
            CreateTable(
                "dbo.Recipe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(storeType: "ntext"),
                        AccessType = c.Byte(),
                        ImageList = c.String(unicode: false, storeType: "text"),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        UserModifyId = c.Int(),
                        UserCreatedId = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecipeFlavour", "RecipeId", "dbo.Recipe");
            DropForeignKey("dbo.RecipeFlavour", "FlavourId", "dbo.Flavour");
            DropForeignKey("dbo.Order", "UserAccountId", "dbo.UserAccount");
            DropForeignKey("dbo.OrderDetail", "OrderId", "dbo.Order");
            DropForeignKey("dbo.OrderHistory", "UserAccountId", "dbo.UserAccount");
            DropForeignKey("dbo.OrderHistoryDetail", "OrderHistoryId", "dbo.OrderHistory");
            DropForeignKey("dbo.FeedBack", "UserAccountId", "dbo.UserAccount");
            DropForeignKey("dbo.Budget", "UserId", "dbo.UserAccount");
            DropIndex("dbo.Recipe", new[] { "Name" });
            DropIndex("dbo.RecipeFlavour", new[] { "FlavourId" });
            DropIndex("dbo.RecipeFlavour", new[] { "RecipeId" });
            DropIndex("dbo.Flavour", new[] { "Name" });
            DropIndex("dbo.OrderDetail", new[] { "OrderId" });
            DropIndex("dbo.Order", new[] { "UserAccountId" });
            DropIndex("dbo.OrderHistoryDetail", new[] { "OrderHistoryId" });
            DropIndex("dbo.OrderHistory", new[] { "UserAccountId" });
            DropIndex("dbo.FeedBack", new[] { "UserAccountId" });
            DropIndex("dbo.UserAccount", new[] { "PhoneNumber" });
            DropIndex("dbo.UserAccount", new[] { "Email" });
            DropIndex("dbo.Budget", new[] { "UserId" });
            DropIndex("dbo.Book", new[] { "Name" });
            DropTable("dbo.Recipe");
            DropTable("dbo.RecipeFlavour");
            DropTable("dbo.Image");
            DropTable("dbo.Flavour");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Order");
            DropTable("dbo.OrderHistoryDetail");
            DropTable("dbo.OrderHistory");
            DropTable("dbo.FeedBack");
            DropTable("dbo.UserAccount");
            DropTable("dbo.Budget");
            DropTable("dbo.Book");
        }
    }
}
