using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Data.Core.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Data.Persistence
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DbContext", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Affiliation> Affiliations { get; set; }
        public virtual DbSet<Agency> Agencies { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customers_Rewards> Customers_Rewards { get; set; }
        public virtual DbSet<Fee> Fees { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Products_Suppliers> Products_Suppliers { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Reward> Rewards { get; set; }
        public virtual DbSet<SupplierContact> SupplierContacts { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TripType> TripTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Affiliation>()
                .HasMany(e => e.SupplierContacts)
                .WithOptional(e => e.Affiliation)
                .HasForeignKey(e => e.AffiliationId);

            modelBuilder.Entity<BookingDetail>()
                .Property(e => e.BasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BookingDetail>()
                .Property(e => e.AgencyCommission)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CreditCards)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Customers_Rewards)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fee>()
                .Property(e => e.FeeAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Package>()
                .Property(e => e.PkgBasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Package>()
                .Property(e => e.PkgAgencyCommission)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Package>()
                .HasMany(e => e.Products_Suppliers)
                .WithMany(e => e.Packages)
                .Map(m => m.ToTable("Packages_Products_Suppliers").MapLeftKey("PackageId").MapRightKey("ProductSupplierId"));

            modelBuilder.Entity<Reward>()
                .HasMany(e => e.Customers_Rewards)
                .WithRequired(e => e.Reward)
                .WillCascadeOnDelete(false);

            // Add this line to ensure identity for security is added properly
            base.OnModelCreating(modelBuilder);
        }
    }
}