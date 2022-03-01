using Microsoft.EntityFrameworkCore.Migrations;

namespace AirCrewHelper_Model.Migrations
{
    public partial class correcaoCheckListEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "AirPlane",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "AirCrew",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CheckList",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "CheckList");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AirPlane",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AirCrew",
                newName: "Nome");
        }
    }
}
