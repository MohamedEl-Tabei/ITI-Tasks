using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_2.Migrations
{
    /// <inheritdoc />
    public partial class migration13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_St_SuperObjSt_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_St_SuperObjSt_Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "St_SuperObjSt_Id",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "St_Super",
                table: "Students",
                newName: "St_SuperId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_St_SuperId",
                table: "Students",
                column: "St_SuperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_St_SuperId",
                table: "Students",
                column: "St_SuperId",
                principalTable: "Students",
                principalColumn: "St_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_St_SuperId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_St_SuperId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "St_SuperId",
                table: "Students",
                newName: "St_Super");

            migrationBuilder.AddColumn<int>(
                name: "St_SuperObjSt_Id",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_St_SuperObjSt_Id",
                table: "Students",
                column: "St_SuperObjSt_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_St_SuperObjSt_Id",
                table: "Students",
                column: "St_SuperObjSt_Id",
                principalTable: "Students",
                principalColumn: "St_Id");
        }
    }
}
