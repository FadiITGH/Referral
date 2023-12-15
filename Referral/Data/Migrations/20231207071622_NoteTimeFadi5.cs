using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Referral.Data.Migrations
{
    public partial class NoteTimeFadi5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "ReferralTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefNote",
                table: "ReferralTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "ReferralTable",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "ReferralTable");

            migrationBuilder.DropColumn(
                name: "RefNote",
                table: "ReferralTable");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "ReferralTable");
        }
    }
}
