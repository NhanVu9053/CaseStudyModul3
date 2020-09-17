using Microsoft.EntityFrameworkCore.Migrations;

namespace BookHouse.Migrations
{
    public partial class editDanhMuctable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sachs_DanhMucSachs_DanhMucSachDanhMucSacId",
                table: "Sachs");

            migrationBuilder.DropIndex(
                name: "IX_Sachs_DanhMucSachDanhMucSacId",
                table: "Sachs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucSachs",
                table: "DanhMucSachs");

            migrationBuilder.DropColumn(
                name: "DanhMucSachDanhMucSacId",
                table: "Sachs");

            migrationBuilder.DropColumn(
                name: "DanhMucSacId",
                table: "DanhMucSachs");

            migrationBuilder.AddColumn<int>(
                name: "DanhMucSachId",
                table: "Sachs",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MoTa",
                table: "DanhMucSachs",
                maxLength: 10000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 10000);

            migrationBuilder.AddColumn<int>(
                name: "DanhMucSachId",
                table: "DanhMucSachs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucSachs",
                table: "DanhMucSachs",
                column: "DanhMucSachId");

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_DanhMucSachId",
                table: "Sachs",
                column: "DanhMucSachId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sachs_DanhMucSachs_DanhMucSachId",
                table: "Sachs",
                column: "DanhMucSachId",
                principalTable: "DanhMucSachs",
                principalColumn: "DanhMucSachId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sachs_DanhMucSachs_DanhMucSachId",
                table: "Sachs");

            migrationBuilder.DropIndex(
                name: "IX_Sachs_DanhMucSachId",
                table: "Sachs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucSachs",
                table: "DanhMucSachs");

            migrationBuilder.DropColumn(
                name: "DanhMucSachId",
                table: "Sachs");

            migrationBuilder.DropColumn(
                name: "DanhMucSachId",
                table: "DanhMucSachs");

            migrationBuilder.AddColumn<int>(
                name: "DanhMucSachDanhMucSacId",
                table: "Sachs",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MoTa",
                table: "DanhMucSachs",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10000,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DanhMucSacId",
                table: "DanhMucSachs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucSachs",
                table: "DanhMucSachs",
                column: "DanhMucSacId");

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_DanhMucSachDanhMucSacId",
                table: "Sachs",
                column: "DanhMucSachDanhMucSacId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sachs_DanhMucSachs_DanhMucSachDanhMucSacId",
                table: "Sachs",
                column: "DanhMucSachDanhMucSacId",
                principalTable: "DanhMucSachs",
                principalColumn: "DanhMucSacId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
