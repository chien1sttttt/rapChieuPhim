using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rapChieuPhim.Data.Migrations
{
    public partial class seedidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 25, 16, 14, 48, 734, DateTimeKind.Local).AddTicks(8265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 25, 16, 1, 41, 345, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("695025d4-e840-421e-ab3f-2fc2e240da61"), "806745ae-5a6e-4179-b335-24251096d1b6", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("5edfca40-c950-4820-883f-310bd37edb54"), new Guid("695025d4-e840-421e-ab3f-2fc2e240da61") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("5edfca40-c950-4820-883f-310bd37edb54"), 0, "5897ffbc-8d02-4bbd-82b4-40f2a2db2f11", new DateTime(2020, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "chien1sttttt@gmail.com", true, "Chien", "Van", false, null, "chien1sttttt@gmail.com", "chien", "AQAAAAEAACcQAAAAEJotWQdqoxFfTvD2czYZ6S6YVZodstWhMcLI3FTUStqXiYHOxpGrIg9w61sjphBTjg==", null, false, "", false, "chien" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 25, 16, 14, 48, 790, DateTimeKind.Local).AddTicks(1133));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("695025d4-e840-421e-ab3f-2fc2e240da61"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("5edfca40-c950-4820-883f-310bd37edb54"), new Guid("695025d4-e840-421e-ab3f-2fc2e240da61") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5edfca40-c950-4820-883f-310bd37edb54"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 25, 16, 1, 41, 345, DateTimeKind.Local).AddTicks(2090),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 25, 16, 14, 48, 734, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 25, 16, 1, 41, 392, DateTimeKind.Local).AddTicks(8797));
        }
    }
}
