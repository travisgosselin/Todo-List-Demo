using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace TodoListDemo.Data
{
    public class TodoListContext : DbContext
    {
        public DbSet<TodoList> Lists { get; set; }

        public DbSet<TodoListItem> ListItems { get; set; }
    }
}
