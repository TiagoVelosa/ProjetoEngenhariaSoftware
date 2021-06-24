using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibraryEngSoft.Migrations
{
    public partial class M020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Credentials_CredentialsID",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescricoes_Persons_ClientID",
                table: "Prescricoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescricoes_Persons_DoctorID",
                table: "Prescricoes");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessions_Persons_ClientID",
                table: "TherapySessions");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessions_Persons_DoctorID",
                table: "TherapySessions");

            migrationBuilder.RenameColumn(
                name: "DoctorID",
                table: "TherapySessions",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "TherapySessions",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_TherapySessions_DoctorID",
                table: "TherapySessions",
                newName: "IX_TherapySessions_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_TherapySessions_ClientID",
                table: "TherapySessions",
                newName: "IX_TherapySessions_ClientId");

            migrationBuilder.RenameColumn(
                name: "DoctorID",
                table: "Prescricoes",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Prescricoes",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescricoes_DoctorID",
                table: "Prescricoes",
                newName: "IX_Prescricoes_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescricoes_ClientID",
                table: "Prescricoes",
                newName: "IX_Prescricoes_ClientId");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Persons",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Persons",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "datebirth",
                table: "Persons",
                newName: "Datebirth");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Persons",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "CredentialsID",
                table: "Persons",
                newName: "CredentialsId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Persons",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "salary",
                table: "Persons",
                newName: "Salary");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_CredentialsID",
                table: "Persons",
                newName: "IX_Persons_CredentialsId");

            migrationBuilder.RenameColumn(
                name: "frequency",
                table: "Items",
                newName: "Frequency");

            migrationBuilder.RenameColumn(
                name: "dosage",
                table: "Items",
                newName: "Dosage");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Credentials_CredentialsId",
                table: "Persons",
                column: "CredentialsId",
                principalTable: "Credentials",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescricoes_Persons_ClientId",
                table: "Prescricoes",
                column: "ClientId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescricoes_Persons_DoctorId",
                table: "Prescricoes",
                column: "DoctorId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySessions_Persons_ClientId",
                table: "TherapySessions",
                column: "ClientId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySessions_Persons_DoctorId",
                table: "TherapySessions",
                column: "DoctorId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Credentials_CredentialsId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescricoes_Persons_ClientId",
                table: "Prescricoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescricoes_Persons_DoctorId",
                table: "Prescricoes");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessions_Persons_ClientId",
                table: "TherapySessions");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessions_Persons_DoctorId",
                table: "TherapySessions");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "TherapySessions",
                newName: "DoctorID");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "TherapySessions",
                newName: "ClientID");

            migrationBuilder.RenameIndex(
                name: "IX_TherapySessions_DoctorId",
                table: "TherapySessions",
                newName: "IX_TherapySessions_DoctorID");

            migrationBuilder.RenameIndex(
                name: "IX_TherapySessions_ClientId",
                table: "TherapySessions",
                newName: "IX_TherapySessions_ClientID");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Prescricoes",
                newName: "DoctorID");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Prescricoes",
                newName: "ClientID");

            migrationBuilder.RenameIndex(
                name: "IX_Prescricoes_DoctorId",
                table: "Prescricoes",
                newName: "IX_Prescricoes_DoctorID");

            migrationBuilder.RenameIndex(
                name: "IX_Prescricoes_ClientId",
                table: "Prescricoes",
                newName: "IX_Prescricoes_ClientID");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Persons",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Persons",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Datebirth",
                table: "Persons",
                newName: "datebirth");

            migrationBuilder.RenameColumn(
                name: "CredentialsId",
                table: "Persons",
                newName: "CredentialsID");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Persons",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Persons",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Persons",
                newName: "salary");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_CredentialsId",
                table: "Persons",
                newName: "IX_Persons_CredentialsID");

            migrationBuilder.RenameColumn(
                name: "Frequency",
                table: "Items",
                newName: "frequency");

            migrationBuilder.RenameColumn(
                name: "Dosage",
                table: "Items",
                newName: "dosage");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Credentials_CredentialsID",
                table: "Persons",
                column: "CredentialsID",
                principalTable: "Credentials",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescricoes_Persons_ClientID",
                table: "Prescricoes",
                column: "ClientID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescricoes_Persons_DoctorID",
                table: "Prescricoes",
                column: "DoctorID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

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
    }
}
