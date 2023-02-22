using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessagerDb.Migrations
{
    /// <inheritdoc />
    public partial class Fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageHistories_Contacts_ContactId",
                table: "MessageHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageHistories",
                table: "MessageHistories");

            migrationBuilder.RenameTable(
                name: "MessageHistories",
                newName: "Messages");

            migrationBuilder.RenameIndex(
                name: "IX_MessageHistories_ContactId",
                table: "Messages",
                newName: "IX_Messages_ContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Contacts_ContactId",
                table: "Messages",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Contacts_ContactId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "MessageHistories");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_ContactId",
                table: "MessageHistories",
                newName: "IX_MessageHistories_ContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageHistories",
                table: "MessageHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageHistories_Contacts_ContactId",
                table: "MessageHistories",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
