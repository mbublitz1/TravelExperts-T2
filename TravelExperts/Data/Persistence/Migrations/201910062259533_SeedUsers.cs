namespace Data.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'40b65be3-8371-43f1-bf57-707ee5228afb', N'john@travelexperts.com', 0, N'AOHRoOvlje8vqX8KkPHjCGy5BRA+xfdrtNhoKsf29V9Ctz+O6VBN9cC09m7xVGdkGQ==', N'47cc79c4-4db4-4238-a1a6-d182be7486cc', NULL, 0, 0, NULL, 1, 0, N'john@travelexperts.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'58ab2bed-4d7f-47dc-bad2-1cbc0e1d784a', N'sumit@travelexperts.com', 0, N'AMAuF4K6KdZLCYf0Imf1gAr/oJmUF3Eb7zbyXmWuGwYPqgncJnNnZro3pH3UkIT+Tw==', N'4824aea1-814d-4afb-9591-d54a09fe2448', NULL, 0, 0, NULL, 1, 0, N'sumit@travelexperts.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8100a2ea-dcfd-4eec-a2b1-6af567a99c89', N'mike@travelexperts.com', 0, N'ACT+naaTp9N0Ih1Aq8mym27kNFhiNtjZIJpSGB+0ixJFVCEk7nP+oB4hEVrqkya8Jw==', N'786dc645-f031-4e81-9b32-119aa2339de9', NULL, 0, 0, NULL, 1, 0, N'mike@travelexperts.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'85966486-3f43-4696-8957-fab3225c2c2f', N'cole@travelexperts.com', 0, N'AHsaO94xD69MsaY8IRTF3PiZUFZlt0G31IbX/T4jv75T5aV3tP8qeEbdO01zFZjoLQ==', N'05be6381-9fd1-409b-8acd-ca5edc5ace02', NULL, 0, 0, NULL, 1, 0, N'cole@travelexperts.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b48fdc42-9659-45bc-b632-e0db3001fc3f', N'admin@travelexperts.com', 0, N'ABM9w9Hr+9xlqduQU+e5PayaI2MIh7CIfYlhHvA9pEbPUGCXhJsBOXfdCvnyPRiE5g==', N'ddd9de3f-3123-4e1c-91f0-e9b6c7e58573', NULL, 0, 0, NULL, 1, 0, N'admin@travelexperts.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cdcc68a5-6eb3-4dfd-83d3-90c74ef3c870', N'guest@travelexperts.com', 0, N'ACtsFKm1pWTEUGTdp2/76S7XKvKboTtmKcyHVaM5xdtohqZOv+ded/wGsJBoxJuEqw==', N'12e804c5-52e6-4c45-b27b-48886ff7a9d2', NULL, 0, 0, NULL, 1, 0, N'guest@travelexperts.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'68fb0255-5bbc-423a-8bb5-3188cce722d7', N'CanManageApp')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'40b65be3-8371-43f1-bf57-707ee5228afb', N'68fb0255-5bbc-423a-8bb5-3188cce722d7')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'58ab2bed-4d7f-47dc-bad2-1cbc0e1d784a', N'68fb0255-5bbc-423a-8bb5-3188cce722d7')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8100a2ea-dcfd-4eec-a2b1-6af567a99c89', N'68fb0255-5bbc-423a-8bb5-3188cce722d7')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'85966486-3f43-4696-8957-fab3225c2c2f', N'68fb0255-5bbc-423a-8bb5-3188cce722d7')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b48fdc42-9659-45bc-b632-e0db3001fc3f', N'68fb0255-5bbc-423a-8bb5-3188cce722d7')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
