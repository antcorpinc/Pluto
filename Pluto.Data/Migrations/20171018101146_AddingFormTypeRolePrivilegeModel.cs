using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pluto.Data.Migrations
{
    public partial class AddingFormTypeRolePrivilegeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormTypeRolePrivilege",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormTypeId = table.Column<int>(type: "int", nullable: false),
                    Privileges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeRolePrivilege", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormTypeRolePrivilege_FormType_FormTypeId",
                        column: x => x.FormTypeId,
                        principalTable: "FormType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormTypeRolePrivilege_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeRolePrivilege_FormTypeId",
                table: "FormTypeRolePrivilege",
                column: "FormTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeRolePrivilege_RoleId",
                table: "FormTypeRolePrivilege",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormTypeRolePrivilege");
        }
    }
}
