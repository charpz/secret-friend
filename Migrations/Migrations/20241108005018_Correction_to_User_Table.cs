using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class Correction_to_User_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SecretFriendId",
                table: "Users",
                newName: "UnsortGroupId");

            migrationBuilder.AddColumn<bool>(
                name: "HasSecretFriend",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasSecretFriend",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UnsortGroupId",
                table: "Users",
                newName: "SecretFriendId");
        }
    }
}
