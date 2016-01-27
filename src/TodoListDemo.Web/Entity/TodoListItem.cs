using System;
using System.ComponentModel.DataAnnotations;

namespace TodoListDemo.Web.Entity
{
    public class TodoListItem
    {
        [Key]
        public int ListItemId { get; set; }

        public int ListId { get; set; }

        public string Item { get; set; }

        public DateTime LastModified { get; set; }

        public bool IsCompleted { get; set; }

        public TodoList TodoList { get; set; }
    }
}
