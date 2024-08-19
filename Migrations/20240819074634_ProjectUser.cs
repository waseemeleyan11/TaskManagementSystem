using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class ProjectUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userID",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_userID",
                table: "Projects",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_userID",
                table: "Projects",
                column: "userID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_userID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_userID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "Projects");
        }
    }
}
