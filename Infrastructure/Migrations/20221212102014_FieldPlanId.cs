using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class FieldPlanId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Plan_PlanId",
                schema: "Gym",
                table: "Customer");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlanId",
                schema: "Gym",
                table: "Customer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Plan_PlanId",
                schema: "Gym",
                table: "Customer",
                column: "PlanId",
                principalSchema: "Gym",
                principalTable: "Plan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Plan_PlanId",
                schema: "Gym",
                table: "Customer");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlanId",
                schema: "Gym",
                table: "Customer",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Plan_PlanId",
                schema: "Gym",
                table: "Customer",
                column: "PlanId",
                principalSchema: "Gym",
                principalTable: "Plan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
