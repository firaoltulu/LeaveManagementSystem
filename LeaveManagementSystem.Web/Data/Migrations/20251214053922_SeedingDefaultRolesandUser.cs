using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7089fec3-0830-46fc-bcbc-e554318a4a0c", null, "Administrator", "ADMINISTRATOR" },
                    { "d7d4cae5-cab1-42f9-a57d-dca852c084c7", null, "Employee", "EMPLOYEE" },
                    { "fa514c47-2b71-4fd6-b83d-2d5f017fa801", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "02bfb38a-3b2c-45da-9b3b-016053151a0d", 0, "73079454-da06-4711-9d4b-eccd47c94940", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIcykL7RoIc7HfkAXXCCdXqT5YWeRzL7TGD1ffoa0+ysEkSQgtV5Ge063hqpkrJG6Q==", null, false, "ebbbac7e-f0a2-466e-a6d9-cdfe43146871", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7089fec3-0830-46fc-bcbc-e554318a4a0c", "02bfb38a-3b2c-45da-9b3b-016053151a0d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7d4cae5-cab1-42f9-a57d-dca852c084c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa514c47-2b71-4fd6-b83d-2d5f017fa801");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7089fec3-0830-46fc-bcbc-e554318a4a0c", "02bfb38a-3b2c-45da-9b3b-016053151a0d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7089fec3-0830-46fc-bcbc-e554318a4a0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02bfb38a-3b2c-45da-9b3b-016053151a0d");
        }
    }
}
