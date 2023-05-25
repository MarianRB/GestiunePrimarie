using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimarieWeb.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cetateans",
                columns: table => new
                {
                    CetateanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cetateans", x => x.CetateanId);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    ChatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nrParticipanti = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CetateanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.ChatId);
                    table.ForeignKey(
                        name: "FK_Chats_Cetateans_CetateanId",
                        column: x => x.CetateanId,
                        principalTable: "Cetateans",
                        principalColumn: "CetateanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descriere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlFisier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CetateanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Documents_Cetateans_CetateanId",
                        column: x => x.CetateanId,
                        principalTable: "Cetateans",
                        principalColumn: "CetateanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eveniments",
                columns: table => new
                {
                    EvenimentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeEveniment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descriere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataEveniment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CetateanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eveniments", x => x.EvenimentId);
                    table.ForeignKey(
                        name: "FK_Eveniments_Cetateans_CetateanId",
                        column: x => x.CetateanId,
                        principalTable: "Cetateans",
                        principalColumn: "CetateanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_CetateanId",
                table: "Chats",
                column: "CetateanId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_CetateanId",
                table: "Documents",
                column: "CetateanId");

            migrationBuilder.CreateIndex(
                name: "IX_Eveniments_CetateanId",
                table: "Eveniments",
                column: "CetateanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Eveniments");

            migrationBuilder.DropTable(
                name: "Cetateans");
        }
    }
}
