namespace CRBS_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initiateUserRegistration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookingInfo",
                c => new
                    {
                        BookingId = c.String(nullable: false, maxLength: 128),
                        PropertyId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        BookingDate = c.DateTime(nullable: false),
                        FromTime = c.String(),
                        ToTime = c.String(),
                        BookingStatus = c.String(),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.ConferenceRoomInfo", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.PropertyId);
            
            CreateTable(
                "dbo.ConferenceRoomInfo",
                c => new
                    {
                        PropertyId = c.Int(nullable: false, identity: true),
                        PropertyName = c.String(),
                        PersonCapacity = c.Int(nullable: false),
                        PropertyPurposeId = c.Int(nullable: false),
                        RoomTypeId = c.Int(nullable: false),
                        FairAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropertyId)
                .ForeignKey("dbo.PropertyTypeInfoes", t => t.PropertyPurposeId, cascadeDelete: true)
                .ForeignKey("dbo.RoomTypes", t => t.RoomTypeId, cascadeDelete: true)
                .Index(t => t.PropertyPurposeId)
                .Index(t => t.RoomTypeId);
            
            CreateTable(
                "dbo.PropertyTypeInfoes",
                c => new
                    {
                        PropertyPurposeId = c.Int(nullable: false, identity: true),
                        PropertyPurposeName = c.String(),
                    })
                .PrimaryKey(t => t.PropertyPurposeId);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        RoomTypeId = c.Int(nullable: false, identity: true),
                        RoomTypeName = c.String(),
                    })
                .PrimaryKey(t => t.RoomTypeId);
            
            CreateTable(
                "dbo.GenderInfoes",
                c => new
                    {
                        GenderId = c.Int(nullable: false, identity: true),
                        GenderName = c.String(),
                    })
                .PrimaryKey(t => t.GenderId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserTypeId = c.Int(nullable: false),
                        FullName = c.String(),
                        ContacNo = c.String(),
                        GenderId = c.Int(nullable: false),
                        Address = c.String(),
                        Fax = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GenderInfoes", t => t.GenderId, cascadeDelete: true)
                .Index(t => t.GenderId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "GenderId", "dbo.GenderInfoes");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ConferenceRoomInfo", "RoomTypeId", "dbo.RoomTypes");
            DropForeignKey("dbo.ConferenceRoomInfo", "PropertyPurposeId", "dbo.PropertyTypeInfoes");
            DropForeignKey("dbo.BookingInfo", "PropertyId", "dbo.ConferenceRoomInfo");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUsers", new[] { "GenderId" });
            DropIndex("dbo.ConferenceRoomInfo", new[] { "RoomTypeId" });
            DropIndex("dbo.ConferenceRoomInfo", new[] { "PropertyPurposeId" });
            DropIndex("dbo.BookingInfo", new[] { "PropertyId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.GenderInfoes");
            DropTable("dbo.RoomTypes");
            DropTable("dbo.PropertyTypeInfoes");
            DropTable("dbo.ConferenceRoomInfo");
            DropTable("dbo.BookingInfo");
        }
    }
}
