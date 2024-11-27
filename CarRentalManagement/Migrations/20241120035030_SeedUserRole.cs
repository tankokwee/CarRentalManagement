using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c11b3698-f7f1-4789-ab03-5e787d69f0a8", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENdd6Rud8OvFtA6KFCnoJ6EWY7BBy4tJ6m6L0uR2WHOT0ZvY+lSkCLn18q2fIuPmEg==", null, false, "9e9669c9-81aa-43c4-92e0-9d7302483d2b", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(2898), new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3201), new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3202), new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3130), new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3132), new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3133), new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3135), new DateTime(2024, 11, 20, 11, 50, 29, 839, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5289), new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5571), new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5573), new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5500), new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5502), new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5503), new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 11, 18, 11, 49, 55, 934, DateTimeKind.Local).AddTicks(5505) });
        }
    }
}
