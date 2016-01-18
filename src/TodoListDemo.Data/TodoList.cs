using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListDemo.Data
{
    public class TodoList
    {
        public TodoList()
        {
            TodoListItems = new List<TodoListItem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ListId { get; set; }

        public string Token { get; set; }

        public virtual List<TodoListItem> TodoListItems { get; set; }
    }
}
