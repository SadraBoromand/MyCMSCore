using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addImageForPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 1,
                columns: new[] { "CreateDate", "Image" },
                values: new object[] { new DateTime(2021, 7, 3, 22, 55, 15, 818, DateTimeKind.Local).AddTicks(2555), "1.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Pages");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 7, 3, 22, 28, 3, 544, DateTimeKind.Local).AddTicks(1086));
        }
    }
}
