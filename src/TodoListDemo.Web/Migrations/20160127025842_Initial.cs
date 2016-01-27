using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

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
                    ListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    ListItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsCompleted = table.Column<bool>(nullable: false),
                    Item = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    ListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoListItem", x => x.ListItemId);
                    table.ForeignKey(
                        name: "FK_TodoListItem_TodoList_ListId",
                        column: x => x.ListId,
                        principalTable: "TodoList",
                        principalColumn: "ListId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("TodoListItem");
            migrationBuilder.DropTable("TodoList");
        }
    }
}
