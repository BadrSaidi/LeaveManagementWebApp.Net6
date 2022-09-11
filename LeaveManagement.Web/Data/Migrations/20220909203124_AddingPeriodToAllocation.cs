using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "438a431c-b61a-1998-a4a2-b16e3676af49",
                column: "ConcurrencyStamp",
                value: "18051538-0f04-42fd-87e7-a7715d63b2b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999a431c-b61a-2022-a4a2-b16e2022dd99",
                column: "ConcurrencyStamp",
                value: "bd3c197d-72f4-439a-84b1-fda2fb21ed69");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "416a431c-b61a-4294-a4a2-b16e3676bb77",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8d6e5e6-2886-4115-900c-f755ae782d33", "AQAAAAEAACcQAAAAEMHlKZT99YyJVrtCVJHEwnui8VYm3Gkylbt3cgWYQR6vYOSI7T1LoWiGvGR9xZlFmw==", "be96e523-0801-4a05-ad3c-bc48e06fbbc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558a431c-b61a-4294-a4a2-b16e3676ce49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65b7ad4c-3fd8-4a2e-8c2a-5d05da5c8977", "AQAAAAEAACcQAAAAEAy+J18kZQWv+60BVoPXd5ccUevB3qM9gMsKdnPBRXMLB+wGKdNhACtIGCtXRlw0YQ==", "7b72c943-46d8-419a-aae9-f191a7bc74a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "901fc1cd-5c76-4ce2-88b8-4c99b024e381", "AQAAAAEAACcQAAAAELyBTwnMER5UeVEkc5IyBksjDCo7oFYTE33uPiyUyRCM/nqfofRbAtj/5peO8Ru6+g==", "00a891d5-43d7-46c4-a52f-f71ae0dec31a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558a431c-b61a-4294-a4a2-b16e3676ce49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff0c173-6c35-45da-8df8-1f5b936d21ee", "AQAAAAEAACcQAAAAEOfvJ9TZgkto0iI9U1wk6JVcxft4mWr1RBiaw8Zvjcdw3L+T84/XSKeDaBsMeZyF9g==", "8c321fb3-a274-4e46-b7af-8ded1907d67e" });
        }
    }
}
