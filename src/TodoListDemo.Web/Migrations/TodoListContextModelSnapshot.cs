using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TodoListDemo.Data;

namespace TodoListDemo.Web.Migrations
{
    [DbContext(typeof(TodoListContext))]
    partial class TodoListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoListDemo.Data.TodoList", b =>
                {
                    b.Property<string>("ListId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Token");

                    b.HasKey("ListId");
                });

            modelBuilder.Entity("TodoListDemo.Data.TodoListItem", b =>
                {
                    b.Property<string>("ListItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsCompleted");

                    b.Property<string>("Item");

                    b.Property<DateTime>("LastModified");

                    b.Property<int>("ListId");

                    b.Property<string>("TodoListListId");

                    b.HasKey("ListItemId");
                });

            modelBuilder.Entity("TodoListDemo.Data.TodoListItem", b =>
                {
                    b.HasOne("TodoListDemo.Data.TodoList")
                        .WithMany()
                        .HasForeignKey("TodoListListId");
                });
        }
    }
}
