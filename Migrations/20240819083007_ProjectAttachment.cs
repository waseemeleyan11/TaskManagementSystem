using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class ProjectAttachment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "attachmentId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_attachmentId",
                table: "Projects",
                column: "attachmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Attachments_attachmentId",
                table: "Projects",
                column: "attachmentId",
                principalTable: "Attachments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Attachments_attachmentId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_attachmentId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "attachmentId",
                table: "Projects");
        }
    }
}
