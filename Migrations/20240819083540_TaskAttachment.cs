using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class TaskAttachment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttachmentId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AttachmentId",
                table: "Tasks",
                column: "AttachmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Attachments_AttachmentId",
                table: "Tasks",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Attachments_AttachmentId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AttachmentId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "Tasks");
        }
    }
}
