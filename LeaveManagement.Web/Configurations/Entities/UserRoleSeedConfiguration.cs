using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "416a431c-b61a-4294-a4a2-b16e3676bb77",
                    RoleId = "438a431c-b61a-1998-a4a2-b16e3676af49"
                },
                new IdentityUserRole<string>
                {
                    UserId = "558a431c-b61a-4294-a4a2-b16e3676ce49",
                    RoleId = "999a431c-b61a-2022-a4a2-b16e2022dd99"
                }

                );
        }
    }
}