using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pluto.Data.Migrations
{
    public partial class AddedFeatureType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkflowCompletedDate",
                table: "FormInstance",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentFormId",
                table: "FormInstance",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<int>(
                name: "NextApproverOrder",
                table: "FormInstance",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkflowCompletedDate",
                table: "FormInstance",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentFormId",
                table: "FormInstance",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NextApproverOrder",
                table: "FormInstance",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
