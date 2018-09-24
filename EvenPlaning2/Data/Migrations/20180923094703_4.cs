using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EvenPlaning2.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubThem_EventModel_EventModelId",
                table: "SubThem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubThem",
                table: "SubThem");

            migrationBuilder.RenameTable(
                name: "SubThem",
                newName: "SubThems");

            migrationBuilder.RenameIndex(
                name: "IX_SubThem_EventModelId",
                table: "SubThems",
                newName: "IX_SubThems_EventModelId");

            migrationBuilder.AddColumn<int>(
                name: "CountOfPartesipantes",
                table: "EventInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxCountOfPartesipantes",
                table: "EventInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubThems",
                table: "SubThems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubThems_EventModel_EventModelId",
                table: "SubThems",
                column: "EventModelId",
                principalTable: "EventModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubThems_EventModel_EventModelId",
                table: "SubThems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubThems",
                table: "SubThems");

            migrationBuilder.DropColumn(
                name: "CountOfPartesipantes",
                table: "EventInfo");

            migrationBuilder.DropColumn(
                name: "MaxCountOfPartesipantes",
                table: "EventInfo");

            migrationBuilder.RenameTable(
                name: "SubThems",
                newName: "SubThem");

            migrationBuilder.RenameIndex(
                name: "IX_SubThems_EventModelId",
                table: "SubThem",
                newName: "IX_SubThem_EventModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubThem",
                table: "SubThem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubThem_EventModel_EventModelId",
                table: "SubThem",
                column: "EventModelId",
                principalTable: "EventModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
