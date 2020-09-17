using Microsoft.EntityFrameworkCore.Migrations;

namespace BookHouse.Migrations
{
    public partial class EditTableSach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TenSach",
                table: "Sachs",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<int>(
                name: "GiaSach",
                table: "Sachs",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 50000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TenSach",
                table: "Sachs",
                type: "int",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaSach",
                table: "Sachs",
                type: "decimal(18,2)",
                maxLength: 50000,
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
