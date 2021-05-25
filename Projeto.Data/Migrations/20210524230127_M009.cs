using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Data.Migrations
{
    public partial class M009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Persons_UserId",
                table: "Prescriptions");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Prescriptions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Persons_UserId",
                table: "Prescriptions",
                column: "UserId",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Persons_UserId",
                table: "Prescriptions");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Prescriptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Persons_UserId",
                table: "Prescriptions",
                column: "UserId",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
