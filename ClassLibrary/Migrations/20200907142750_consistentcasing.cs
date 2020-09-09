using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary.Migrations
{
    public partial class consistentcasing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Employee",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Employee",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Department",
                newName: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Employee",
                newName: "DepartmentID");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employee",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Department",
                newName: "DepartmentID");
        }
    }
}
