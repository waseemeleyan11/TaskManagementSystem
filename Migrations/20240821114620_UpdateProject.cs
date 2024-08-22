using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Attachments_AttachmentId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_AttachmentId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "Projects");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttachmentId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AttachmentId",
                table: "Projects",
                column: "AttachmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Attachments_AttachmentId",
                table: "Projects",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
