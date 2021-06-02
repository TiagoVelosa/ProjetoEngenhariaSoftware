using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibraryEngSoft.Migrations
{
    public partial class M003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessions_Persons_DoctorID",
                table: "TherapySessions");

            migrationBuilder.DropColumn(
                name: "TreatmentID",
                table: "Item");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorID",
                table: "TherapySessions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "TherapySessions",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorID",
                table: "Prescricoes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "Prescricoes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionID",
                table: "Item",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_TherapySessions_ClientID",
                table: "TherapySessions",
                column: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySessions_Persons_ClientID",
                table: "TherapySessions",
                column: "ClientID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySessions_Persons_DoctorID",
                table: "TherapySessions",
                column: "DoctorID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessions_Persons_ClientID",
                table: "TherapySessions");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessions_Persons_DoctorID",
                table: "TherapySessions");

            migrationBuilder.DropIndex(
                name: "IX_TherapySessions_ClientID",
                table: "TherapySessions");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "TherapySessions");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorID",
                table: "TherapySessions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorID",
                table: "Prescricoes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "Prescricoes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionID",
                table: "Item",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TreatmentID",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySessions_Persons_DoctorID",
                table: "TherapySessions",
                column: "DoctorID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
