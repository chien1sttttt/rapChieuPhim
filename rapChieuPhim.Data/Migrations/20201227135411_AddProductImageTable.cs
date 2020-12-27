﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rapChieuPhim.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 27, 20, 54, 9, 955, DateTimeKind.Local).AddTicks(6539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 25, 23, 14, 56, 157, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("695025d4-e840-421e-ab3f-2fc2e240da61"),
                column: "ConcurrencyStamp",
                value: "aca4438c-3d00-4f91-8d41-5e02bb1c7f88");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5edfca40-c950-4820-883f-310bd37edb54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "688f929a-f175-496e-8ba9-dc62b41a562e", "AQAAAAEAACcQAAAAEMXTH1ooffPeu6NilnVxhHEKEY+6syGYmQQfiBeVF7Qmqzj4hqDaEPhnc49qaPo6Ew==" });

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
                value: new DateTime(2020, 12, 27, 20, 54, 10, 4, DateTimeKind.Local).AddTicks(260));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 25, 23, 14, 56, 157, DateTimeKind.Local).AddTicks(6878),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 27, 20, 54, 9, 955, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("695025d4-e840-421e-ab3f-2fc2e240da61"),
                column: "ConcurrencyStamp",
                value: "d8543144-c9f9-4604-abdf-69e240b126b6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5edfca40-c950-4820-883f-310bd37edb54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ffd100a-8e0d-4f9b-a6c4-e4b9a92f9101", "AQAAAAEAACcQAAAAEEiv7kI5CsQq1j6Gx+tDBiBERXNNObd/KE4kWXLUsdBy8qjPxJkPT1nGVi4aj2NqsQ==" });

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
                value: new DateTime(2020, 12, 25, 23, 14, 56, 194, DateTimeKind.Local).AddTicks(3485));
        }
    }
}
