using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoListDemo.Web.Entity
{
    public class TodoList
    {
        public TodoList()
        {
            TodoListItems = new List<TodoListItem>();
        }

        [Key]
        public int ListId { get; set; }

        public string Token { get; set; }

        public virtual List<TodoListItem> TodoListItems { get; set; }
    }
}
