using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DigWalProj.Migrations
{
    public partial class UpdatedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PMTeamteamId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PMTeamteamId1",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    adId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    adDescription = table.Column<string>(type: "TEXT", nullable: true),
                    adName = table.Column<string>(type: "TEXT", nullable: true),
                    projectId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.adId);
                });

            migrationBuilder.CreateTable(
                name: "PMTeam",
                columns: table => new
                {
                    teamId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    teamDescription = table.Column<string>(type: "TEXT", nullable: true),
                    teamName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMTeam", x => x.teamId);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    projId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PMTeamteamId = table.Column<int>(type: "INTEGER", nullable: true),
                    ProjectName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.projId);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectprojId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PMTeamteamId",
                table: "AspNetUsers",
                column: "PMTeamteamId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PMTeamteamId1",
                table: "AspNetUsers",
                column: "PMTeamteamId1");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ProjectprojId",
                table: "Accounts",
                column: "ProjectprojId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_PMTeamteamId",
                table: "Project",
                column: "PMTeamteamId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PMTeam_PMTeamteamId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PMTeam_PMTeamteamId1",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "PMTeam");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PMTeamteamId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PMTeamteamId1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PMTeamteamId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PMTeamteamId1",
                table: "AspNetUsers");
        }
    }
}
