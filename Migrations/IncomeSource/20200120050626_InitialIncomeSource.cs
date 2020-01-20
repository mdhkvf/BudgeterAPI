using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthAPI.Migrations.IncomeSource
{
    public partial class InitialIncomeSource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IncomeSources",
                columns: table => new
                {
                    IncomeSourceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    PayDate = table.Column<DateTime>(nullable: false),
                    Frequency = table.Column<string>(type: "VARCHAR(12)", maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeSources", x => x.IncomeSourceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomeSources");
        }
    }
}
