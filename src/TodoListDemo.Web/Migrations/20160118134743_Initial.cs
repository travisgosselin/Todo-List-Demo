using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace TodoListDemo.Web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoList",
                columns: table => new
                {
                    ListId = table.Column<string>(nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoList", x => x.ListId);
                });
            migrationBuilder.CreateTable(
                name: "TodoListItem",
                columns: table => new
                {
                    ListItemId = table.Column<string>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false),
                    Item = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    ListId = table.Column<int>(nullable: false),
                    TodoListListId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoListItem", x => x.ListItemId);
                    table.ForeignKey(
                        name: "FK_TodoListItem_TodoList_TodoListListId",
                        column: x => x.TodoListListId,
                        principalTable: "TodoList",
                        principalColumn: "ListId",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("TodoListItem");
            migrationBuilder.DropTable("TodoList");
        }
    }
}
