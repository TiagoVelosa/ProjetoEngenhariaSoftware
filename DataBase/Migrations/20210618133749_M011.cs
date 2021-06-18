using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibraryEngSoft.Migrations
{
    public partial class M011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionID",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionID",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
