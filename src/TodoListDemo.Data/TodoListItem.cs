using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListDemo.Data
{
    public class TodoListItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ListItemId { get; set; }

        public int ListId { get; set; }

        public string Item { get; set; }

        public DateTime LastModified { get; set; }

        public bool IsCompleted { get; set; }

        public TodoList TodoList { get; set; }
    }
}
