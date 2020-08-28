using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProject.WebAPI.Migrations
{
    public partial class account_add_user_join_add_role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expenses",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Account");

            migrationBuilder.AddColumn<decimal>(
                name: "Expenses",
                table: "User",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "User",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Account",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expenses",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Account");

            migrationBuilder.AddColumn<decimal>(
                name: "Expenses",
                table: "Account",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Account",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
