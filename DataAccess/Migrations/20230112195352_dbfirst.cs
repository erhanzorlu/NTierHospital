using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dbfirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_Policlinic_PoliclinicID",
                table: "Nurses");

            migrationBuilder.RenameColumn(
                name: "PoliclinicID",
                table: "Nurses",
                newName: "PoliklinikID");

            migrationBuilder.RenameIndex(
                name: "IX_Nurses_PoliclinicID",
                table: "Nurses",
                newName: "IX_Nurses_PoliklinikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Policlinic_PoliklinikID",
                table: "Nurses",
                column: "PoliklinikID",
                principalTable: "Policlinic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_Policlinic_PoliklinikID",
                table: "Nurses");

            migrationBuilder.RenameColumn(
                name: "PoliklinikID",
                table: "Nurses",
                newName: "PoliclinicID");

            migrationBuilder.RenameIndex(
                name: "IX_Nurses_PoliklinikID",
                table: "Nurses",
                newName: "IX_Nurses_PoliclinicID");

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Policlinic_PoliclinicID",
                table: "Nurses",
                column: "PoliclinicID",
                principalTable: "Policlinic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
