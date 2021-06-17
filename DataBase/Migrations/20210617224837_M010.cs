using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibraryEngSoft.Migrations
{
    public partial class M010 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Prescricoes_PrescriptionID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_TherapySessions_SessionID",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Item_SessionID",
                table: "Items",
                newName: "IX_Items_SessionID");

            migrationBuilder.RenameIndex(
                name: "IX_Item_PrescriptionID",
                table: "Items",
                newName: "IX_Items_PrescriptionID");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeSugestion",
                table: "Items",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Prescricoes_PrescriptionID",
                table: "Items",
                column: "PrescriptionID",
                principalTable: "Prescricoes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_TherapySessions_SessionID",
                table: "Items",
                column: "SessionID",
                principalTable: "TherapySessions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Prescricoes_PrescriptionID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_TherapySessions_SessionID",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SessionID",
                table: "Item",
                newName: "IX_Item_SessionID");

            migrationBuilder.RenameIndex(
                name: "IX_Items_PrescriptionID",
                table: "Item",
                newName: "IX_Item_PrescriptionID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeSugestion",
                table: "Item",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Prescricoes_PrescriptionID",
                table: "Item",
                column: "PrescriptionID",
                principalTable: "Prescricoes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_TherapySessions_SessionID",
                table: "Item",
                column: "SessionID",
                principalTable: "TherapySessions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
