using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "438a431c-b61a-1998-a4a2-b16e3676af49",
                column: "ConcurrencyStamp",
                value: "10f6fdf3-3714-4ae5-814d-de68d0e53d24");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999a431c-b61a-2022-a4a2-b16e2022dd99",
                column: "ConcurrencyStamp",
                value: "a4efbb08-7aac-46e2-8f81-afc3d6c1cf5a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "416a431c-b61a-4294-a4a2-b16e3676bb77",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "901fc1cd-5c76-4ce2-88b8-4c99b024e381", true, "BADR-INTER@HOTMAIL.CA", "AQAAAAEAACcQAAAAELyBTwnMER5UeVEkc5IyBksjDCo7oFYTE33uPiyUyRCM/nqfofRbAtj/5peO8Ru6+g==", "00a891d5-43d7-46c4-a52f-f71ae0dec31a", "badr-inter@hotmail.ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558a431c-b61a-4294-a4a2-b16e3676ce49",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3ff0c173-6c35-45da-8df8-1f5b936d21ee", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOfvJ9TZgkto0iI9U1wk6JVcxft4mWr1RBiaw8Zvjcdw3L+T84/XSKeDaBsMeZyF9g==", "8c321fb3-a274-4e46-b7af-8ded1907d67e", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "438a431c-b61a-1998-a4a2-b16e3676af49",
                column: "ConcurrencyStamp",
                value: "99e65212-d28c-48d9-bbe5-2c459ced5a30");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999a431c-b61a-2022-a4a2-b16e2022dd99",
                column: "ConcurrencyStamp",
                value: "72753939-398b-42fb-83b6-92038e9c5e54");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "416a431c-b61a-4294-a4a2-b16e3676bb77",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4d4c2a6f-8603-47ba-9ad5-26309952666d", false, null, "AQAAAAEAACcQAAAAEHJZ1vNt7XAmig0rlPYSsZFqvX+oK5v5XhHL5X0VXaey5yb6Pfpn0/PXMx2coXanMQ==", "9e47dfd1-bafc-4da9-b074-2b130a4b2eed", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558a431c-b61a-4294-a4a2-b16e3676ce49",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "654bd1b2-e837-42b2-80ac-95dc037f98a1", false, null, "AQAAAAEAACcQAAAAEMVKlkQsu8YsfnRlb6WYrq6GRuR4w1ueWEgf+GAXGHfgMA/P3g9flxxmGtQHS9BL8A==", "17817f8c-0ab6-4457-b5e8-60e13ce20c5d", null });
        }
    }
}
