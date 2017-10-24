using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pluto.Data.Migrations
{
    public partial class AddedFormStatusAndRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "FormInstance");

            migrationBuilder.AddColumn<int>(
                name: "FormStatusId",
                table: "FormInstance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FormStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StatusName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormInstance_FormStatusId",
                table: "FormInstance",
                column: "FormStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormInstance_FormStatus_FormStatusId",
                table: "FormInstance",
                column: "FormStatusId",
                principalTable: "FormStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormInstance_FormStatus_FormStatusId",
                table: "FormInstance");

            migrationBuilder.DropTable(
                name: "FormStatus");

            migrationBuilder.DropIndex(
                name: "IX_FormInstance_FormStatusId",
                table: "FormInstance");

            migrationBuilder.DropColumn(
                name: "FormStatusId",
                table: "FormInstance");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "FormInstance",
                nullable: false,
                defaultValue: 0);
        }
    }
}
