using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookHouse.Migrations
{
    public partial class CreateDanhMucSach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMucSachs",
                columns: table => new
                {
                    DanhMucSacId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDanhMuc = table.Column<string>(maxLength: 500, nullable: false),
                    MoTa = table.Column<string>(maxLength: 10000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucSachs", x => x.DanhMucSacId);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    SachID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSach = table.Column<int>(maxLength: 500, nullable: false),
                    TacGia = table.Column<string>(maxLength: 500, nullable: false),
                    NXB = table.Column<string>(maxLength: 500, nullable: false),
                    NgayXuatBan = table.Column<DateTime>(nullable: false),
                    TomTatSach = table.Column<string>(maxLength: 100000, nullable: false),
                    AnhSach = table.Column<string>(nullable: true),
                    GiaSach = table.Column<decimal>(maxLength: 50000, nullable: false),
                    DanhMucId = table.Column<int>(nullable: false),
                    DanhMucSachDanhMucSacId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.SachID);
                    table.ForeignKey(
                        name: "FK_Sachs_DanhMucSachs_DanhMucSachDanhMucSacId",
                        column: x => x.DanhMucSachDanhMucSacId,
                        principalTable: "DanhMucSachs",
                        principalColumn: "DanhMucSacId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_DanhMucSachDanhMucSacId",
                table: "Sachs",
                column: "DanhMucSachDanhMucSacId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sachs");

            migrationBuilder.DropTable(
                name: "DanhMucSachs");
        }
    }
}
