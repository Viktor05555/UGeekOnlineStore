﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UGeekStore.Migrations
{
    public partial class passwordHashandPasswordSalt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Users",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldDefaultValue: new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddDate",
                table: "Products",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldDefaultValue: new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 17, 22, 44, 278, DateTimeKind.Local).AddTicks(3216),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 2, 21, 9, 5, 46, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendTime",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 17, 22, 44, 288, DateTimeKind.Local).AddTicks(2344),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 2, 21, 9, 5, 55, DateTimeKind.Local).AddTicks(6395));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Users",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldDefaultValue: new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "NVARCHAR(25)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddDate",
                table: "Products",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldDefaultValue: new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 2, 21, 9, 5, 46, DateTimeKind.Local).AddTicks(4329),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 9, 17, 22, 44, 278, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendTime",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 2, 21, 9, 5, 55, DateTimeKind.Local).AddTicks(6395),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 9, 17, 22, 44, 288, DateTimeKind.Local).AddTicks(2344));
        }
    }
}
