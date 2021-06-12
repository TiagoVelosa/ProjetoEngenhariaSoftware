using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibraryEngSoft.Migrations
{
    public partial class M004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "CredentialsID",
                table: "Persons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Credentials",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credentials", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CredentialsID",
                table: "Persons",
                column: "CredentialsID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Credentials_CredentialsID",
                table: "Persons",
                column: "CredentialsID",
                principalTable: "Credentials",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Credentials_CredentialsID",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Credentials");

            migrationBuilder.DropIndex(
                name: "IX_Persons_CredentialsID",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CredentialsID",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
