using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "438a431c-b61a-1998-a4a2-b16e3676af49", "99e65212-d28c-48d9-bbe5-2c459ced5a30", "Administrator", "ADMINISTRATOR" },
                    { "999a431c-b61a-2022-a4a2-b16e2022dd99", "72753939-398b-42fb-83b6-92038e9c5e54", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "416a431c-b61a-4294-a4a2-b16e3676bb77", 0, "4d4c2a6f-8603-47ba-9ad5-26309952666d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "badr-inter@hotmail.ca", false, "Badr", "Saidi", false, null, "BADR-INTER@HOTMAIL.CA", null, "AQAAAAEAACcQAAAAEHJZ1vNt7XAmig0rlPYSsZFqvX+oK5v5XhHL5X0VXaey5yb6Pfpn0/PXMx2coXanMQ==", null, false, "9e47dfd1-bafc-4da9-b074-2b130a4b2eed", null, false, null },
                    { "558a431c-b61a-4294-a4a2-b16e3676ce49", 0, "654bd1b2-e837-42b2-80ac-95dc037f98a1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "User", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMVKlkQsu8YsfnRlb6WYrq6GRuR4w1ueWEgf+GAXGHfgMA/P3g9flxxmGtQHS9BL8A==", null, false, "17817f8c-0ab6-4457-b5e8-60e13ce20c5d", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "438a431c-b61a-1998-a4a2-b16e3676af49", "416a431c-b61a-4294-a4a2-b16e3676bb77" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "999a431c-b61a-2022-a4a2-b16e2022dd99", "558a431c-b61a-4294-a4a2-b16e3676ce49" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "438a431c-b61a-1998-a4a2-b16e3676af49", "416a431c-b61a-4294-a4a2-b16e3676bb77" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "999a431c-b61a-2022-a4a2-b16e2022dd99", "558a431c-b61a-4294-a4a2-b16e3676ce49" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "438a431c-b61a-1998-a4a2-b16e3676af49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999a431c-b61a-2022-a4a2-b16e2022dd99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "416a431c-b61a-4294-a4a2-b16e3676bb77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558a431c-b61a-4294-a4a2-b16e3676ce49");
        }
    }
}
