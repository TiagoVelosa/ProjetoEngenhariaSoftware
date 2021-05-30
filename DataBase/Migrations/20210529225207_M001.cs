using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibraryEngSoft.Migrations
{
    public partial class M001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    telefone = table.Column<int>(nullable: false),
                    datebirth = table.Column<DateTime>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    salary = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prescricoes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    PrescriptionDate = table.Column<DateTime>(nullable: false),
                    ClientID = table.Column<int>(nullable: false),
                    DoctorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescricoes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prescricoes_Persons_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescricoes_Persons_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TherapySessions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    DoctorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TherapySessions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TherapySessions_Persons_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PrescriptionID = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    TimeSugestion = table.Column<DateTime>(nullable: true),
                    dosage = table.Column<double>(nullable: true),
                    frequency = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Done = table.Column<bool>(nullable: true),
                    TreatmentID = table.Column<int>(nullable: true),
                    SessionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Item_Prescricoes_PrescriptionID",
                        column: x => x.PrescriptionID,
                        principalTable: "Prescricoes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_TherapySessions_SessionID",
                        column: x => x.SessionID,
                        principalTable: "TherapySessions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_PrescriptionID",
                table: "Item",
                column: "PrescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SessionID",
                table: "Item",
                column: "SessionID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescricoes_ClientID",
                table: "Prescricoes",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescricoes_DoctorID",
                table: "Prescricoes",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_TherapySessions_DoctorID",
                table: "TherapySessions",
                column: "DoctorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Prescricoes");

            migrationBuilder.DropTable(
                name: "TherapySessions");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
