using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "id", "Description", "Name" },
                values: new object[] { new Guid("214ee928-54b9-4ee6-9308-edd2efc46700"), "Canal dedicado a ReactJs", "ReactJs" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "id", "Description", "Name" },
                values: new object[] { new Guid("241b2a74-3963-493c-980c-451079597285"), "Canal dedicado a dotnetcore", "DotNetCore" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "id", "Description", "Name" },
                values: new object[] { new Guid("ad38c33a-16a5-4e65-9efa-10e45fc8cf1b"), "Canal dedicado a Angular", "Angular" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "id",
                keyValue: new Guid("214ee928-54b9-4ee6-9308-edd2efc46700"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "id",
                keyValue: new Guid("241b2a74-3963-493c-980c-451079597285"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "id",
                keyValue: new Guid("ad38c33a-16a5-4e65-9efa-10e45fc8cf1b"));
        }
    }
}
