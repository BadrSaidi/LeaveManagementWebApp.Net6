using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();

            builder.HasData(
                new Employee
                {
                    Id = "416a431c-b61a-4294-a4a2-b16e3676bb77",
                    Email = "badr-inter@hotmail.ca",
                    NormalizedEmail = "BADR-INTER@HOTMAIL.CA",
                    UserName = "badr-inter@hotmail.ca",
                    NormalizedUserName = "BADR-INTER@HOTMAIL.CA",
                    FirstName = "Badr",
                    LastName = "Saidi",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true

                },
                new Employee
                {
                    Id = "558a431c-b61a-4294-a4a2-b16e3676ce49",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
                );
        }
    }
}