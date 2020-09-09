using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary.Migrations
{
    public partial class removeHyphen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department_ID",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Employee",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "Department_ID",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
