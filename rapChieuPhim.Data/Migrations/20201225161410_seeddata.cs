using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rapChieuPhim.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 25, 23, 14, 9, 717, DateTimeKind.Local).AddTicks(9906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 25, 23, 13, 30, 499, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("695025d4-e840-421e-ab3f-2fc2e240da61"),
                column: "ConcurrencyStamp",
                value: "8b56103d-06cc-4516-918f-f9c6be1062d3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5edfca40-c950-4820-883f-310bd37edb54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28a5bd83-7794-4542-b010-d586e1e19383", "AQAAAAEAACcQAAAAEErT0U4wcTgAuwNHU7Y8R9I0GsJMvJ64ZOAD8DXJgqLkXTeLQpS1llVyZfRiRmtXhg==" });

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
                value: new DateTime(2020, 12, 25, 23, 14, 9, 761, DateTimeKind.Local).AddTicks(5760));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 25, 23, 13, 30, 499, DateTimeKind.Local).AddTicks(2529),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 25, 23, 14, 9, 717, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("695025d4-e840-421e-ab3f-2fc2e240da61"),
                column: "ConcurrencyStamp",
                value: "a1042bc6-43d2-4b6d-85dc-2ba7770c1309");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5edfca40-c950-4820-883f-310bd37edb54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4e90ca5-afa6-4cb4-abf1-1c1af6f18891", "AQAAAAEAACcQAAAAEEJ6l5MuJ+Ba3jEA3OJ34l3uuFcb84QQaYQYlqciQQ8MzDClQk3ZG4TSvgTAPNZ3aw==" });

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
                value: new DateTime(2020, 12, 25, 23, 13, 30, 545, DateTimeKind.Local).AddTicks(2073));
        }
    }
}
