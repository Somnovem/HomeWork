using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ado10_1EF.Migrations
{
    /// <inheritdoc />
    public partial class Consr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "CK_Firstname",
                table: "Peoples",
                sql: "Firstname <> ''");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Firstname",
                table: "Peoples");
        }
    }
}
