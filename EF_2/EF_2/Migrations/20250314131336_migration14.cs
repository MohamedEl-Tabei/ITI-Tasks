using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_2.Migrations
{
    /// <inheritdoc />
    public partial class migration14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dept_Manger",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Dept_Manger",
                table: "Departments",
                column: "Dept_Manger",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Dept_Manger",
                table: "Departments",
                column: "Dept_Manger",
                principalTable: "Instructors",
                principalColumn: "Ins_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Dept_Manger",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Dept_Manger",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Dept_Manger",
                table: "Departments");
        }
    }
}
