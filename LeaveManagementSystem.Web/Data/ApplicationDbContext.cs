using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
               new IdentityRole
               {
                   Id= "d7d4cae5-cab1-42f9-a57d-dca852c084c7",
                   Name="Employee",
                   NormalizedName="EMPLOYEE"
               },
               new IdentityRole
               {
                   Id = "fa514c47-2b71-4fd6-b83d-2d5f017fa801",
                   Name = "Supervisor",
                   NormalizedName = "SUPERVISOR"
               },
               new IdentityRole
               {
                   Id = "7089fec3-0830-46fc-bcbc-e554318a4a0c",
                   Name = "Administrator",
                   NormalizedName = "ADMINISTRATOR"
               }
            );

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "02bfb38a-3b2c-45da-9b3b-016053151a0d",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "Password1"),
                    EmailConfirmed = true,
                    FirstName = "Default",
                    LastName = "Admin",
                    DateOfBirth = new DateOnly(1998, 08, 01)
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "7089fec3-0830-46fc-bcbc-e554318a4a0c",
                    UserId = "02bfb38a-3b2c-45da-9b3b-016053151a0d"
                }
            );

        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }

}
//(localdb)\\mssqllocaldb