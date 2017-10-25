using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pluto.Data.Migrations
{
    public partial class FeatureModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeatureType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    ParentFeatureId = table.Column<int>(type: "int", nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocietyFeature",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatureTypeId = table.Column<int>(type: "int", nullable: false),
                    SocietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocietyFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocietyFeature_FeatureType_FeatureTypeId",
                        column: x => x.FeatureTypeId,
                        principalTable: "FeatureType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocietyFeature_Society_SocietyId",
                        column: x => x.SocietyId,
                        principalTable: "Society",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFeatureTypeMapping",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatureTypeId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFeatureTypeMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFeatureTypeMapping_FeatureType_FeatureTypeId",
                        column: x => x.FeatureTypeId,
                        principalTable: "FeatureType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFeatureTypeMapping_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFeatureTypeMapping_Society_SocietyId",
                        column: x => x.SocietyId,
                        principalTable: "Society",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFeatureTypeMapping_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SocietyFeature_FeatureTypeId",
                table: "SocietyFeature",
                column: "FeatureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SocietyFeature_SocietyId",
                table: "SocietyFeature",
                column: "SocietyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFeatureTypeMapping_FeatureTypeId",
                table: "UserFeatureTypeMapping",
                column: "FeatureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFeatureTypeMapping_RoleId",
                table: "UserFeatureTypeMapping",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFeatureTypeMapping_SocietyId",
                table: "UserFeatureTypeMapping",
                column: "SocietyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFeatureTypeMapping_UserId",
                table: "UserFeatureTypeMapping",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocietyFeature");

            migrationBuilder.DropTable(
                name: "UserFeatureTypeMapping");

            migrationBuilder.DropTable(
                name: "FeatureType");
        }
    }
}
