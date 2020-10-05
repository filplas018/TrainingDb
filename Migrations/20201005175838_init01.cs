using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XOPOW.Migrations
{
    public partial class init01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Morodecs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    LOLRank = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Term = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morodecs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Morodecs",
                columns: new[] { "Id", "Address", "Date", "LOLRank", "Name", "Size", "Term" },
                values: new object[] { 1, "Do Pískovny 72, Mníšek", new DateTime(2001, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ajron3", "Rodec", 14, "Není Chálec jako chálec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Morodecs");
        }
    }
}
