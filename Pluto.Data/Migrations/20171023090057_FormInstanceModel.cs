using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pluto.Data.Migrations
{
    public partial class FormInstanceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormInstance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormInstanceContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormTypeId = table.Column<int>(type: "int", nullable: false),
                    InputterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NextApproverOrder = table.Column<int>(type: "int", nullable: false),
                    ParentFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    WorkflowCompletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormInstance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormInstance_FormType_FormTypeId",
                        column: x => x.FormTypeId,
                        principalTable: "FormType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormInstance_Society_SocietyId",
                        column: x => x.SocietyId,
                        principalTable: "Society",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormInstance_FormTypeId",
                table: "FormInstance",
                column: "FormTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FormInstance_SocietyId",
                table: "FormInstance",
                column: "SocietyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormInstance");
        }
    }
}
