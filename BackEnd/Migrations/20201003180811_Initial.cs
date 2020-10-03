using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    City = table.Column<string>(maxLength: 200, nullable: true),
                    State = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Injuries = table.Column<int>(nullable: true),
                    Deaths = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SourceName = table.Column<string>(nullable: false),
                    URL = table.Column<string>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IncidentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Source_Incidents_IncidentID",
                        column: x => x.IncidentID,
                        principalTable: "Incidents",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Source_IncidentID",
                table: "Source",
                column: "IncidentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Incidents");
        }
    }
}
