using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABD.Checkpoint2.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ARTISTA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Nacionalidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Idade = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ARTISTA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_MUSICA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    ArtistaId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    AnoLancamento = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_MUSICA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_MUSICA_TB_ARTISTA_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "TB_ARTISTA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_MUSICA_ArtistaId",
                table: "TB_MUSICA",
                column: "ArtistaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_MUSICA");

            migrationBuilder.DropTable(
                name: "TB_ARTISTA");
        }
    }
}
