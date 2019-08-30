using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImalatMontaj.Talep.Mvc.Migrations
{
    public partial class initialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Taleps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tip = table.Column<string>(nullable: false),
                    UrunTanimi = table.Column<string>(maxLength: 200, nullable: false),
                    TalepEdilenYer = table.Column<string>(maxLength: 50, nullable: false),
                    TalepEdenAdSoyad = table.Column<string>(maxLength: 50, nullable: false),
                    TalepEdenTarihi = table.Column<DateTime>(nullable: false),
                    TalepEdenDepartman = table.Column<string>(maxLength: 50, nullable: false),
                    TalepOnayAdSoyad = table.Column<string>(maxLength: 50, nullable: true),
                    TalepOnayTarihi = table.Column<DateTime>(nullable: true),
                    TalepYapanAdSoyad = table.Column<string>(maxLength: 50, nullable: true),
                    TalepYapanTalepTarihi = table.Column<DateTime>(nullable: true),
                    TalepYapanDepartman = table.Column<string>(maxLength: 50, nullable: true),
                    TalepKontrolAdSoyad = table.Column<string>(maxLength: 50, nullable: true),
                    TalepKontrolTarihi = table.Column<DateTime>(nullable: true),
                    TalepKontrolDepartman = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taleps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Yol = table.Column<string>(maxLength: 100, nullable: false),
                    TalepId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foto_Taleps_TalepId",
                        column: x => x.TalepId,
                        principalTable: "Taleps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foto_TalepId",
                table: "Foto",
                column: "TalepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foto");

            migrationBuilder.DropTable(
                name: "Taleps");
        }
    }
}
