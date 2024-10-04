using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo_App.Migrations
{
    /// <inheritdoc />
    public partial class changedId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tasks",
                newName: "SNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SNo",
                table: "Tasks",
                newName: "Id");
        }
    }
}
