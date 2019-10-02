using System.Data.Entity.Migrations;

namespace Data.Persistence.Migrations
{
    public partial class initialModel : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Affiliations",
            //    c => new
            //    {
            //        AffilitationId = c.String(nullable: false, maxLength: 10),
            //        AffName = c.String(maxLength: 50),
            //        AffDesc = c.String(maxLength: 50),
            //    })
            //    .PrimaryKey(t => t.AffilitationId);

            //CreateTable(
            //    "dbo.SupplierContacts",
            //    c => new
            //    {
            //        SupplierContactId = c.Int(nullable: false),
            //        SupConFirstName = c.String(maxLength: 50),
            //        SupConLastName = c.String(maxLength: 50),
            //        SupConCompany = c.String(maxLength: 255),
            //        SupConAddress = c.String(maxLength: 255),
            //        SupConCity = c.String(maxLength: 255),
            //        SupConProv = c.String(maxLength: 255),
            //        SupConPostal = c.String(maxLength: 255),
            //        SupConCountry = c.String(maxLength: 255),
            //        SupConBusPhone = c.String(maxLength: 50),
            //        SupConFax = c.String(maxLength: 50),
            //        SupConEmail = c.String(maxLength: 255),
            //        SupConURL = c.String(maxLength: 255),
            //        AffiliationId = c.String(maxLength: 10),
            //        SupplierId = c.Int(),
            //    })
            //    .PrimaryKey(t => t.SupplierContactId)
            //    .ForeignKey("dbo.Suppliers", t => t.SupplierId)
            //    .ForeignKey("dbo.Affiliations", t => t.AffiliationId)
            //    .Index(t => t.AffiliationId)
            //    .Index(t => t.SupplierId);

            //CreateTable(
            //    "dbo.Suppliers",
            //    c => new
            //    {
            //        SupplierId = c.Int(nullable: false),
            //        SupName = c.String(maxLength: 255),
            //    })
            //    .PrimaryKey(t => t.SupplierId);

            //CreateTable(
            //    "dbo.Products_Suppliers",
            //    c => new
            //    {
            //        ProductSupplierId = c.Int(nullable: false, identity: true),
            //        ProductId = c.Int(),
            //        SupplierId = c.Int(),
            //    })
            //    .PrimaryKey(t => t.ProductSupplierId)
            //    .ForeignKey("dbo.Products", t => t.ProductId)
            //    .ForeignKey("dbo.Suppliers", t => t.SupplierId)
            //    .Index(t => t.ProductId)
            //    .Index(t => t.SupplierId);

            //CreateTable(
            //    "dbo.BookingDetails",
            //    c => new
            //    {
            //        BookingDetailId = c.Int(nullable: false, identity: true),
            //        ItineraryNo = c.Double(),
            //        TripStart = c.DateTime(),
            //        TripEnd = c.DateTime(),
            //        Description = c.String(maxLength: 255),
            //        Destination = c.String(maxLength: 255),
            //        BasePrice = c.Decimal(storeType: "money"),
            //        AgencyCommission = c.Decimal(storeType: "money"),
            //        BookingId = c.Int(),
            //        RegionId = c.String(maxLength: 5),
            //        ClassId = c.String(maxLength: 5),
            //        FeeId = c.String(maxLength: 10),
            //        ProductSupplierId = c.Int(),
            //    })
            //    .PrimaryKey(t => t.BookingDetailId)
            //    .ForeignKey("dbo.Bookings", t => t.BookingId)
            //    .ForeignKey("dbo.Classes", t => t.ClassId)
            //    .ForeignKey("dbo.Fees", t => t.FeeId)
            //    .ForeignKey("dbo.Products_Suppliers", t => t.ProductSupplierId)
            //    .ForeignKey("dbo.Regions", t => t.RegionId)
            //    .Index(t => t.BookingId)
            //    .Index(t => t.RegionId)
            //    .Index(t => t.ClassId)
            //    .Index(t => t.FeeId)
            //    .Index(t => t.ProductSupplierId);

            //CreateTable(
            //    "dbo.Bookings",
            //    c => new
            //    {
            //        BookingId = c.Int(nullable: false, identity: true),
            //        BookingDate = c.DateTime(),
            //        BookingNo = c.String(maxLength: 50),
            //        TravelerCount = c.Double(),
            //        CustomerId = c.Int(),
            //        TripTypeId = c.String(maxLength: 1),
            //        PackageId = c.Int(),
            //    })
            //    .PrimaryKey(t => t.BookingId)
            //    .ForeignKey("dbo.Customers", t => t.CustomerId)
            //    .ForeignKey("dbo.Packages", t => t.PackageId)
            //    .ForeignKey("dbo.TripTypes", t => t.TripTypeId)
            //    .Index(t => t.CustomerId)
            //    .Index(t => t.TripTypeId)
            //    .Index(t => t.PackageId);

            //CreateTable(
            //    "dbo.Customers",
            //    c => new
            //    {
            //        CustomerId = c.Int(nullable: false, identity: true),
            //        CustFirstName = c.String(nullable: false, maxLength: 25),
            //        CustLastName = c.String(nullable: false, maxLength: 25),
            //        CustAddress = c.String(nullable: false, maxLength: 75),
            //        CustCity = c.String(nullable: false, maxLength: 50),
            //        CustProv = c.String(nullable: false, maxLength: 2),
            //        CustPostal = c.String(nullable: false, maxLength: 7),
            //        CustCountry = c.String(maxLength: 25),
            //        CustHomePhone = c.String(maxLength: 20),
            //        CustBusPhone = c.String(nullable: false, maxLength: 20),
            //        CustEmail = c.String(nullable: false, maxLength: 50),
            //        AgentId = c.Int(),
            //    })
            //    .PrimaryKey(t => t.CustomerId)
            //    .ForeignKey("dbo.Agents", t => t.AgentId)
            //    .Index(t => t.AgentId);

            //CreateTable(
            //    "dbo.Agents",
            //    c => new
            //    {
            //        AgentId = c.Int(nullable: false, identity: true),
            //        AgtFirstName = c.String(maxLength: 20),
            //        AgtMiddleInitial = c.String(maxLength: 5),
            //        AgtLastName = c.String(maxLength: 20),
            //        AgtBusPhone = c.String(maxLength: 20),
            //        AgtEmail = c.String(maxLength: 50),
            //        AgtPosition = c.String(maxLength: 20),
            //        AgencyId = c.Int(),
            //    })
            //    .PrimaryKey(t => t.AgentId)
            //    .ForeignKey("dbo.Agencies", t => t.AgencyId)
            //    .Index(t => t.AgencyId);

            //CreateTable(
            //    "dbo.Agencies",
            //    c => new
            //    {
            //        AgencyId = c.Int(nullable: false, identity: true),
            //        AgncyAddress = c.String(maxLength: 50),
            //        AgncyCity = c.String(maxLength: 50),
            //        AgncyProv = c.String(maxLength: 50),
            //        AgncyPostal = c.String(maxLength: 50),
            //        AgncyCountry = c.String(maxLength: 50),
            //        AgncyPhone = c.String(maxLength: 50),
            //        AgncyFax = c.String(maxLength: 50),
            //    })
            //    .PrimaryKey(t => t.AgencyId);

            //CreateTable(
            //    "dbo.CreditCards",
            //    c => new
            //    {
            //        CreditCardId = c.Int(nullable: false, identity: true),
            //        CCName = c.String(nullable: false, maxLength: 10),
            //        CCNumber = c.String(nullable: false, maxLength: 50),
            //        CCExpiry = c.DateTime(nullable: false),
            //        CustomerId = c.Int(nullable: false),
            //    })
            //    .PrimaryKey(t => t.CreditCardId)
            //    .ForeignKey("dbo.Customers", t => t.CustomerId)
            //    .Index(t => t.CustomerId);

            //CreateTable(
            //    "dbo.Customers_Rewards",
            //    c => new
            //    {
            //        CustomerId = c.Int(nullable: false),
            //        RewardId = c.Int(nullable: false),
            //        RwdNumber = c.String(nullable: false, maxLength: 25),
            //    })
            //    .PrimaryKey(t => new { t.CustomerId, t.RewardId })
            //    .ForeignKey("dbo.Rewards", t => t.RewardId)
            //    .ForeignKey("dbo.Customers", t => t.CustomerId)
            //    .Index(t => t.CustomerId)
            //    .Index(t => t.RewardId);

            //CreateTable(
            //    "dbo.Rewards",
            //    c => new
            //    {
            //        RewardId = c.Int(nullable: false),
            //        RwdName = c.String(maxLength: 50),
            //        RwdDesc = c.String(maxLength: 50),
            //    })
            //    .PrimaryKey(t => t.RewardId);

            //CreateTable(
            //    "dbo.Packages",
            //    c => new
            //    {
            //        PackageId = c.Int(nullable: false, identity: true),
            //        PkgName = c.String(nullable: false, maxLength: 50),
            //        PkgStartDate = c.DateTime(),
            //        PkgEndDate = c.DateTime(),
            //        PkgDesc = c.String(maxLength: 50),
            //        PkgBasePrice = c.Decimal(nullable: false, storeType: "money"),
            //        PkgAgencyCommission = c.Decimal(storeType: "money"),
            //    })
            //    .PrimaryKey(t => t.PackageId);

            //CreateTable(
            //    "dbo.TripTypes",
            //    c => new
            //    {
            //        TripTypeId = c.String(nullable: false, maxLength: 1),
            //        TTName = c.String(maxLength: 25),
            //    })
            //    .PrimaryKey(t => t.TripTypeId);

            //CreateTable(
            //    "dbo.Classes",
            //    c => new
            //    {
            //        ClassId = c.String(nullable: false, maxLength: 5),
            //        ClassName = c.String(nullable: false, maxLength: 20),
            //        ClassDesc = c.String(maxLength: 50),
            //    })
            //    .PrimaryKey(t => t.ClassId);

            //CreateTable(
            //    "dbo.Fees",
            //    c => new
            //    {
            //        FeeId = c.String(nullable: false, maxLength: 10),
            //        FeeName = c.String(nullable: false, maxLength: 50),
            //        FeeAmt = c.Decimal(nullable: false, storeType: "money"),
            //        FeeDesc = c.String(maxLength: 50),
            //    })
            //    .PrimaryKey(t => t.FeeId);

            //CreateTable(
            //    "dbo.Regions",
            //    c => new
            //    {
            //        RegionId = c.String(nullable: false, maxLength: 5),
            //        RegionName = c.String(maxLength: 25),
            //    })
            //    .PrimaryKey(t => t.RegionId);

            //CreateTable(
            //    "dbo.Products",
            //    c => new
            //    {
            //        ProductId = c.Int(nullable: false, identity: true),
            //        ProdName = c.String(nullable: false, maxLength: 50),
            //    })
            //    .PrimaryKey(t => t.ProductId);

            //CreateTable(
            //    "dbo.Employees",
            //    c => new
            //    {
            //        EmpFirstName = c.String(nullable: false, maxLength: 20),
            //        EmpLastName = c.String(nullable: false, maxLength: 20),
            //        EmpBusPhone = c.String(nullable: false, maxLength: 20),
            //        EmpEmail = c.String(nullable: false, maxLength: 50),
            //        EmpPosition = c.String(nullable: false, maxLength: 20),
            //        EmpMiddleInitial = c.String(maxLength: 5),
            //    })
            //    .PrimaryKey(t => new { t.EmpFirstName, t.EmpLastName, t.EmpBusPhone, t.EmpEmail, t.EmpPosition });

            CreateTable(
                "dbo.AspNetRoles",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");

            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    RoleId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.AspNetUsers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
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

            //CreateTable(
            //    "dbo.Packages_Products_Suppliers",
            //    c => new
            //    {
            //        PackageId = c.Int(nullable: false),
            //        ProductSupplierId = c.Int(nullable: false),
            //    })
            //    .PrimaryKey(t => new { t.PackageId, t.ProductSupplierId })
            //    .ForeignKey("dbo.Packages", t => t.PackageId, cascadeDelete: true)
            //    .ForeignKey("dbo.Products_Suppliers", t => t.ProductSupplierId, cascadeDelete: true)
            //    .Index(t => t.PackageId)
            //    .Index(t => t.ProductSupplierId);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            ////DropForeignKey("dbo.SupplierContacts", "AffiliationId", "dbo.Affiliations");
            //DropForeignKey("dbo.SupplierContacts", "SupplierId", "dbo.Suppliers");
            //DropForeignKey("dbo.Products_Suppliers", "SupplierId", "dbo.Suppliers");
            //DropForeignKey("dbo.Products_Suppliers", "ProductId", "dbo.Products");
            //DropForeignKey("dbo.BookingDetails", "RegionId", "dbo.Regions");
            //DropForeignKey("dbo.BookingDetails", "ProductSupplierId", "dbo.Products_Suppliers");
            //DropForeignKey("dbo.BookingDetails", "FeeId", "dbo.Fees");
            //DropForeignKey("dbo.BookingDetails", "ClassId", "dbo.Classes");
            //DropForeignKey("dbo.Bookings", "TripTypeId", "dbo.TripTypes");
            //DropForeignKey("dbo.Packages_Products_Suppliers", "ProductSupplierId", "dbo.Products_Suppliers");
            //DropForeignKey("dbo.Packages_Products_Suppliers", "PackageId", "dbo.Packages");
            //DropForeignKey("dbo.Bookings", "PackageId", "dbo.Packages");
            //DropForeignKey("dbo.Customers_Rewards", "CustomerId", "dbo.Customers");
            //DropForeignKey("dbo.Customers_Rewards", "RewardId", "dbo.Rewards");
            //DropForeignKey("dbo.CreditCards", "CustomerId", "dbo.Customers");
            //DropForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers");
            //DropForeignKey("dbo.Customers", "AgentId", "dbo.Agents");
            //DropForeignKey("dbo.Agents", "AgencyId", "dbo.Agencies");
            //DropForeignKey("dbo.BookingDetails", "BookingId", "dbo.Bookings");
            //DropIndex("dbo.Packages_Products_Suppliers", new[] { "ProductSupplierId" });
            //DropIndex("dbo.Packages_Products_Suppliers", new[] { "PackageId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            //DropIndex("dbo.Customers_Rewards", new[] { "RewardId" });
            //DropIndex("dbo.Customers_Rewards", new[] { "CustomerId" });
            //DropIndex("dbo.CreditCards", new[] { "CustomerId" });
            //DropIndex("dbo.Agents", new[] { "AgencyId" });
            //DropIndex("dbo.Customers", new[] { "AgentId" });
            //DropIndex("dbo.Bookings", new[] { "PackageId" });
            //DropIndex("dbo.Bookings", new[] { "TripTypeId" });
            //DropIndex("dbo.Bookings", new[] { "CustomerId" });
            //DropIndex("dbo.BookingDetails", new[] { "ProductSupplierId" });
            //DropIndex("dbo.BookingDetails", new[] { "FeeId" });
            //DropIndex("dbo.BookingDetails", new[] { "ClassId" });
            //DropIndex("dbo.BookingDetails", new[] { "RegionId" });
            //DropIndex("dbo.BookingDetails", new[] { "BookingId" });
            //DropIndex("dbo.Products_Suppliers", new[] { "SupplierId" });
            //DropIndex("dbo.Products_Suppliers", new[] { "ProductId" });
            //DropIndex("dbo.SupplierContacts", new[] { "SupplierId" });
            //DropIndex("dbo.SupplierContacts", new[] { "AffiliationId" });
            //DropTable("dbo.Packages_Products_Suppliers");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            //DropTable("dbo.Employees");
            //DropTable("dbo.Products");
            //DropTable("dbo.Regions");
            //DropTable("dbo.Fees");
            //DropTable("dbo.Classes");
            //DropTable("dbo.TripTypes");
            //DropTable("dbo.Packages");
            //DropTable("dbo.Rewards");
            //DropTable("dbo.Customers_Rewards");
            //DropTable("dbo.CreditCards");
            //DropTable("dbo.Agencies");
            //DropTable("dbo.Agents");
            //DropTable("dbo.Customers");
            //DropTable("dbo.Bookings");
            //DropTable("dbo.BookingDetails");
            //DropTable("dbo.Products_Suppliers");
            //DropTable("dbo.Suppliers");
            //DropTable("dbo.SupplierContacts");
            //DropTable("dbo.Affiliations");
        }
    }
}
