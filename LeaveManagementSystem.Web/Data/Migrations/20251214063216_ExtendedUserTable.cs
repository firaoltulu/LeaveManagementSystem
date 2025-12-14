using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02bfb38a-3b2c-45da-9b3b-016053151a0d",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cedd46b-b2d3-4f60-bdcf-36ab133f7c6d", new DateOnly(1998, 8, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEI0u3P2af51cAkILLS52NestOC7ybuxMfPvqMKtd4MX0kVObZfPN6q03umWwIIJ06g==", "79d57316-89a7-4507-94a2-b05e12b6445b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02bfb38a-3b2c-45da-9b3b-016053151a0d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73079454-da06-4711-9d4b-eccd47c94940", "AQAAAAIAAYagAAAAEIcykL7RoIc7HfkAXXCCdXqT5YWeRzL7TGD1ffoa0+ysEkSQgtV5Ge063hqpkrJG6Q==", "ebbbac7e-f0a2-466e-a6d9-cdfe43146871" });
        }
    }
}
