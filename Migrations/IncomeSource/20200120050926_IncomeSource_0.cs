using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthAPI.Migrations.IncomeSource
{
    public partial class IncomeSource_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "IncomeSources",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "IncomeSources");
        }
    }
}
