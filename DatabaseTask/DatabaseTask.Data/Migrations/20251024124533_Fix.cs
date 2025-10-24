using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Queue");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Queue");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "JobTitle");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "ChildGroupHistory");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "ChildGroupHistory");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Absense");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Absense");

            migrationBuilder.AddColumn<int>(
                name: "AbsenseId",
                table: "Group",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChildGroupHistoryId",
                table: "Group",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "Group",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "Group",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QueueId",
                table: "Group",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "JobTitleId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AbsenseId",
                table: "Child",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChildGroupHistoryId",
                table: "Child",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QueueId",
                table: "Child",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Group_AbsenseId",
                table: "Group",
                column: "AbsenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_ChildGroupHistoryId",
                table: "Group",
                column: "ChildGroupHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_EmployeeId",
                table: "Group",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_MenuId",
                table: "Group",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_QueueId",
                table: "Group",
                column: "QueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobTitleId",
                table: "Employee",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_AbsenseId",
                table: "Child",
                column: "AbsenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_ChildGroupHistoryId",
                table: "Child",
                column: "ChildGroupHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_QueueId",
                table: "Child",
                column: "QueueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Absense_AbsenseId",
                table: "Child",
                column: "AbsenseId",
                principalTable: "Absense",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_ChildGroupHistory_ChildGroupHistoryId",
                table: "Child",
                column: "ChildGroupHistoryId",
                principalTable: "ChildGroupHistory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Queue_QueueId",
                table: "Child",
                column: "QueueId",
                principalTable: "Queue",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_JobTitle_JobTitleId",
                table: "Employee",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Absense_AbsenseId",
                table: "Group",
                column: "AbsenseId",
                principalTable: "Absense",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_ChildGroupHistory_ChildGroupHistoryId",
                table: "Group",
                column: "ChildGroupHistoryId",
                principalTable: "ChildGroupHistory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Employee_EmployeeId",
                table: "Group",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Menu_MenuId",
                table: "Group",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Queue_QueueId",
                table: "Group",
                column: "QueueId",
                principalTable: "Queue",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Absense_AbsenseId",
                table: "Child");

            migrationBuilder.DropForeignKey(
                name: "FK_Child_ChildGroupHistory_ChildGroupHistoryId",
                table: "Child");

            migrationBuilder.DropForeignKey(
                name: "FK_Child_Queue_QueueId",
                table: "Child");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_JobTitle_JobTitleId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Absense_AbsenseId",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_ChildGroupHistory_ChildGroupHistoryId",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Employee_EmployeeId",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Menu_MenuId",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Queue_QueueId",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Group_AbsenseId",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Group_ChildGroupHistoryId",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Group_EmployeeId",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Group_MenuId",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Group_QueueId",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Employee_JobTitleId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Child_AbsenseId",
                table: "Child");

            migrationBuilder.DropIndex(
                name: "IX_Child_ChildGroupHistoryId",
                table: "Child");

            migrationBuilder.DropIndex(
                name: "IX_Child_QueueId",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "AbsenseId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "ChildGroupHistoryId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "QueueId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "JobTitleId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "AbsenseId",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "ChildGroupHistoryId",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "QueueId",
                table: "Child");

            migrationBuilder.AddColumn<Guid>(
                name: "ChildId",
                table: "Queue",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "Queue",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "Menu",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "JobTitle",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ChildId",
                table: "ChildGroupHistory",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "ChildGroupHistory",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ChildId",
                table: "Absense",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "Absense",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
