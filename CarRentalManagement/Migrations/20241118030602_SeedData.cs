using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6097), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6099), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6551), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6553), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6351), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6353), new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6353), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6442), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6444), new DateTime(2024, 11, 18, 11, 6, 1, 171, DateTimeKind.Local).AddTicks(6445), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
