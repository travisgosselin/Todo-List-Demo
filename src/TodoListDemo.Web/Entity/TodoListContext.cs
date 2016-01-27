using Microsoft.Data.Entity;

namespace TodoListDemo.Web.Entity
{
    public class TodoListContext : DbContext
    {
        public DbSet<TodoList> Lists { get; set; }

        public DbSet<TodoListItem> ListItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoListItem>()
               .Property(t => t.ListItemId).UseSqlServerIdentityColumn();

            modelBuilder.Entity<TodoList>()
                .Property(t => t.ListId).UseSqlServerIdentityColumn();
        }
    }
}
