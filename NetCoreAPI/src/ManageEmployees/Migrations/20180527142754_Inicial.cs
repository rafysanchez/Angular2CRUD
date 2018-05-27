﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageEmployees.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2018, 5, 27, 11, 27, 53, 725, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 3, 30, 11, 15, 22, 46, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2018, 5, 27, 11, 27, 53, 798, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 3, 30, 11, 15, 22, 71, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2018, 5, 27, 11, 27, 53, 799, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 3, 30, 11, 15, 22, 72, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2017, 3, 30, 11, 15, 22, 46, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 5, 27, 11, 27, 53, 725, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2017, 3, 30, 11, 15, 22, 71, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 5, 27, 11, 27, 53, 798, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2017, 3, 30, 11, 15, 22, 72, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 5, 27, 11, 27, 53, 799, DateTimeKind.Local));
        }
    }
}
