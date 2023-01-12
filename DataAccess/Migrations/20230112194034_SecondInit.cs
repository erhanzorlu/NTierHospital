using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SecondInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apoinments_Patients_PatientID",
                table: "Apoinments");

            migrationBuilder.DropForeignKey(
                name: "FK_Apoinments_Policlinic_PoliclinicID",
                table: "Apoinments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apoinments",
                table: "Apoinments");

            migrationBuilder.RenameTable(
                name: "Apoinments",
                newName: "Appointments");

            migrationBuilder.RenameColumn(
                name: "ApointmentDate",
                table: "Appointments",
                newName: "AppointmentDate");

            migrationBuilder.RenameIndex(
                name: "IX_Apoinments_PoliclinicID",
                table: "Appointments",
                newName: "IX_Appointments_PoliclinicID");

            migrationBuilder.RenameIndex(
                name: "IX_Apoinments_PatientID",
                table: "Appointments",
                newName: "IX_Appointments_PatientID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientID",
                table: "Appointments",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Policlinic_PoliclinicID",
                table: "Appointments",
                column: "PoliclinicID",
                principalTable: "Policlinic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Policlinic_PoliclinicID",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Apoinments");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "Apoinments",
                newName: "ApointmentDate");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_PoliclinicID",
                table: "Apoinments",
                newName: "IX_Apoinments_PoliclinicID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_PatientID",
                table: "Apoinments",
                newName: "IX_Apoinments_PatientID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apoinments",
                table: "Apoinments",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Apoinments_Patients_PatientID",
                table: "Apoinments",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apoinments_Policlinic_PoliclinicID",
                table: "Apoinments",
                column: "PoliclinicID",
                principalTable: "Policlinic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
