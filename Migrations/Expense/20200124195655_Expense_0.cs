﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthAPI.Migrations.Expense
{
    public partial class Expense_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseCategoryId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ExpenseName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    ExpenseDescription = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(nullable: false),
                    Frequency = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseCategories");

            migrationBuilder.DropTable(
                name: "Expenses");
        }
    }
}
