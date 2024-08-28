using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_comment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Destinations_DestinationDestinatonID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DestinationDestinatonID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DestinationDestinatonID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "DestinatonID",
                table: "Comments",
                newName: "DestinationID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DestinationID",
                table: "Comments",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Destinations_DestinationID",
                table: "Comments",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinatonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Destinations_DestinationID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DestinationID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "DestinationID",
                table: "Comments",
                newName: "DestinatonID");

            migrationBuilder.AddColumn<int>(
                name: "DestinationDestinatonID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DestinationDestinatonID",
                table: "Comments",
                column: "DestinationDestinatonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Destinations_DestinationDestinatonID",
                table: "Comments",
                column: "DestinationDestinatonID",
                principalTable: "Destinations",
                principalColumn: "DestinatonID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
