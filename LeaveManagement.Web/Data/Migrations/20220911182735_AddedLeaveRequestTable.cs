using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "438a431c-b61a-1998-a4a2-b16e3676af49",
                column: "ConcurrencyStamp",
                value: "2f433cbb-46d9-4f45-92cb-6f5e75bbda97");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999a431c-b61a-2022-a4a2-b16e2022dd99",
                column: "ConcurrencyStamp",
                value: "e7bb143d-3f1a-49e2-b71a-ecd280f1b6ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "416a431c-b61a-4294-a4a2-b16e3676bb77",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cf645a9-4471-4377-ab83-2344210314e2", "AQAAAAEAACcQAAAAEHC0c6DydFNrG+BJkxBsgWp9TPFbaCsYCbH7T/iWAHZqSzM7RRyQfATI0m8oO+QPyg==", "837330c7-05f6-44cc-a97f-e8df7a16ebc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558a431c-b61a-4294-a4a2-b16e3676ce49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfbc8421-36d6-4b13-8ec6-d7a3ed6621ee", "AQAAAAEAACcQAAAAEJaa20vidz0di2PO73wkN0qq6HyKDCU/0iMGEAhjD4vqjFzQy+oPqUPphJbDPaTh3g==", "2089c15b-ee8d-4126-91cd-ad637aef599e" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
