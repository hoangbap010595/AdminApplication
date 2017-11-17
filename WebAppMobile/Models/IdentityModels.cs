using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using DataModel.Entity;

namespace WebAppMobile.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
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
        public ApplicationDbContext(): base("name=ShopOnlineContext", throwIfV1Schema: false)
        {

        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Territory> Territories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole>()
            .HasKey(r => new { r.UserId, r.RoleId })
            .ToTable("AspNetUserRoles");

            modelBuilder.Entity<IdentityUserLogin>()
                .HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId })
                .ToTable("AspNetUserLogins");

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Category)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Fax)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.HomePhone)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Employee)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Territories)
                .WithMany(e => e.Employees)
                .Map(m => m.ToTable("EmployeeTerritory").MapLeftKey("EmployeeID").MapRightKey("TerritoryID"));

            modelBuilder.Entity<Order>()
                .Property(e => e.Frieght)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.ShipPhone)
                .IsFixedLength();

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock>()
                .Property(e => e.UnitPricePromotion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock>()
                .HasOptional(e => e.Product)
                .WithRequired(e => e.Stock)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Fax)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Supplier)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Territory>()
                .Property(e => e.Code)
                .IsFixedLength();
        }
    }
}