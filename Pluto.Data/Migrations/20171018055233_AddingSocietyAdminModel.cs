using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pluto.Data.Migrations
{
    public partial class AddingSocietyAdminModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocietyForm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormTypeId = table.Column<int>(type: "int", nullable: false),
                    SocietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocietyForm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocietyForm_FormType_FormTypeId",
                        column: x => x.FormTypeId,
                        principalTable: "FormType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocietyForm_Society_SocietyId",
                        column: x => x.SocietyId,
                        principalTable: "Society",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SocietyForm_FormTypeId",
                table: "SocietyForm",
                column: "FormTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SocietyForm_SocietyId",
                table: "SocietyForm",
                column: "SocietyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocietyForm");
        }
    }
}
