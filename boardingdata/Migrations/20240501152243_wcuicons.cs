using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace boardingdata.Migrations
{
    /// <inheritdoc />
    public partial class wcuicons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconIDFA",
                table: "WCUBoxs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconIDFA",
                table: "WCUBoxs");
        }
    }
}
