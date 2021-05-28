using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class m002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Person_ClientID",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Person_DoctorID",
                table: "Prescriptions");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Person_ClientID",
                table: "Prescriptions",
                column: "ClientID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Person_DoctorID",
                table: "Prescriptions",
                column: "DoctorID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Person_ClientID",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Person_DoctorID",
                table: "Prescriptions");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Person_ClientID",
                table: "Prescriptions",
                column: "ClientID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Person_DoctorID",
                table: "Prescriptions",
                column: "DoctorID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
