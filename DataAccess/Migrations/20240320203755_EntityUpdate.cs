using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EntityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "Currency");

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "Incomes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "Expenses",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "Expenses");

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "Currency",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
