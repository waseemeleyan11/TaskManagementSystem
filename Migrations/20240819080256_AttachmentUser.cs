using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AttachmentUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttachmentId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AttachmentId",
                table: "Users",
                column: "AttachmentId",
                unique: true,
                filter: "[AttachmentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Attachments_AttachmentId",
                table: "Users",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Attachments_AttachmentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AttachmentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "Users");
        }
    }
}
