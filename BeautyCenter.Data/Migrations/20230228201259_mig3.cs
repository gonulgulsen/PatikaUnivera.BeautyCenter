using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 2, 28, 23, 12, 59, 363, DateTimeKind.Local).AddTicks(4742));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 2, 28, 14, 56, 43, 793, DateTimeKind.Local).AddTicks(8258));
        }
    }
}
