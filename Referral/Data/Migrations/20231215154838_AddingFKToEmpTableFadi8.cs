using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Referral.Data.Migrations
{
    public partial class AddingFKToEmpTableFadi8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RefImagePath",
                table: "ReferralTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmpDep",
                table: "ReferralTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralTable_EmpDep",
                table: "ReferralTable",
                column: "EmpDep");

            migrationBuilder.AddForeignKey(
                name: "FK_ReferralTable_DepTable_EmpDep",
                table: "ReferralTable",
                column: "EmpDep",
                principalTable: "DepTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReferralTable_DepTable_EmpDep",
                table: "ReferralTable");

            migrationBuilder.DropIndex(
                name: "IX_ReferralTable_EmpDep",
                table: "ReferralTable");

            migrationBuilder.AlterColumn<string>(
                name: "RefImagePath",
                table: "ReferralTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmpDep",
                table: "ReferralTable",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
