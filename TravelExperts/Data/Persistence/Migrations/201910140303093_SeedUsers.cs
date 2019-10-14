namespace Data.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3fadb475-46c9-4789-84d2-e38ad1d8667d', N'mike@travelexperts.com', 0, N'AEg7B8Mr8Qowlxy94NLQEAfZZeAMy7v9RZI75tSr41sZDXjNT3gGVFTV7Y9b1uJrHA==', N'cae1fbf7-050c-4269-9449-cc638c55086e', NULL, 0, 0, NULL, 1, 0, N'mike@travelexperts.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd4df81d2-3be1-499f-a042-ba1fa737ed39', N'admin@travelexperts.com', 0, N'AM/N1W0kEo1nWTsDd8MEk5aPp7cEtOTqwQFE1SKPdfH2EaGGdHb61pgCpEY9VycpFw==', N'9925a9b2-b722-46e0-861f-f09e4a1f5111', NULL, 0, 0, NULL, 1, 0, N'admin@travelexperts.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f2bb3099-78b2-496c-b700-4f96c668d2a4', N'jreed@aol.com', 0, N'AMlve1sM8ca8c8X19Lm/OilTlcgZmZ02xJ1pvh0mLAD02jYM5o1mIWsEd9DE7M58Ng==', N'fa46c5f8-2b70-4d6b-ab1d-b2e8d64af9d6', NULL, 0, 0, NULL, 1, 0, N'jreed@aol.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f3ef3a1a-7f84-4f3b-ba18-3b83e77ca77e', N'guest@travelexperts.com', 0, N'AGn/TTVYkTTIjr98Q6Xug6XsnqzEjr3MuXUnTlFWolJJyXL8ukC6Mw2fw6dKVKHZIg==', N'a566c6e3-f40a-49d3-a5ab-c86b99823710', NULL, 0, 0, NULL, 1, 0, N'guest@travelexperts.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6185d4a4-1041-41ae-af66-ca240e43db92', N'CanManageApp')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3fadb475-46c9-4789-84d2-e38ad1d8667d', N'6185d4a4-1041-41ae-af66-ca240e43db92')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd4df81d2-3be1-499f-a042-ba1fa737ed39', N'6185d4a4-1041-41ae-af66-ca240e43db92')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f2bb3099-78b2-496c-b700-4f96c668d2a4', N'6185d4a4-1041-41ae-af66-ca240e43db92')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
//INSERT INTO[dbo].[Customers]
//([CustomerId], [CustFirstName], [CustLastName], [CustAddress], [CustCity], [CustProv], [CustPostal], [CustCountry], [CustHomePhone], [CustBusPhone], [CustEmail], [AgentId], [UserId]) VALUES(144, N'Guest', N'Traveller', N'123 Street', N'Edmonton', N'AB', N'T43 3F3', N'Canada', N'7897897897', N'1234567898', N'guest@travelexperts.com', NULL, N'f3ef3a1a-7f84-4f3b-ba18-3b83e77ca77e')
//INSERT INTO[dbo].[Customers]
//([CustomerId], [CustFirstName], [CustLastName], [CustAddress], [CustCity], [CustProv], [CustPostal], [CustCountry], [CustHomePhone], [CustBusPhone], [CustEmail], [AgentId], [UserId]) VALUES(145, N'Admin', N'User', N'Admin', N'Admin', N'AB', N'r4r3e3', N'Admin', N'0000000000', N'0000000000', N'admin@travelexperts.com', NULL, N'd4df81d2-3be1-499f-a042-ba1fa737ed39')
//INSERT INTO[dbo].[Customers]
//([CustomerId], [CustFirstName], [CustLastName], [CustAddress], [CustCity], [CustProv], [CustPostal], [CustCountry], [CustHomePhone], [CustBusPhone], [CustEmail], [AgentId], [UserId]) VALUES(146, N'Mike', N'B', N'123 Street', N'Edmonton', N'AB', N'R4R3R3', N'Canada', N'0000000000', N'0000000000', N'mike@travelexperts.com', NULL, N'3fadb475-46c9-4789-84d2-e38ad1d8667d')
