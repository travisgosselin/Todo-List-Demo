using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TodoListDemo.Web.Entity;

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

            modelBuilder.Entity("TodoListDemo.Web.Entity.TodoList", b =>
                {
                    b.Property<int>("ListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Token");

                    b.HasKey("ListId");
                });

            modelBuilder.Entity("TodoListDemo.Web.Entity.TodoListItem", b =>
                {
                    b.Property<int>("ListItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsCompleted");

                    b.Property<string>("Item");

                    b.Property<DateTime>("LastModified");

                    b.Property<int>("ListId");

                    b.HasKey("ListItemId");
                });

            modelBuilder.Entity("TodoListDemo.Web.Entity.TodoListItem", b =>
                {
                    b.HasOne("TodoListDemo.Web.Entity.TodoList")
                        .WithMany()
                        .HasForeignKey("ListId");
                });
        }
    }
}
