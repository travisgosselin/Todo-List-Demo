using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using TodoListDemo.Web.Entity;

namespace TodoListDemo.Web.Services
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        [FromServices]
        public TodoListContext TodoContext { get; set; }

        [HttpGet]
        [Route("{token}")]
        public IActionResult Get(string token)
        {
            var todo = TodoContext.Lists.Include(t => t.TodoListItems).FirstOrDefault(t => t.Token == token);
            if (todo == null)
            {
                return new HttpNotFoundResult();
            }

            return new ObjectResult(todo);
        }

        [HttpPost]
        [Route("{token}")]
        public TodoListItem Add([FromRoute] string token, [FromBody] TodoListItem item)
        {
            var foundList = TodoContext.Lists.Include(t => t.TodoListItems).FirstOrDefault(t => t.Token == token);
            if (foundList == null)
            {
                foundList = new TodoList
                {
                    Token = token
                };
                TodoContext.Lists.Add(foundList);
            }

            foundList.TodoListItems.Add(item);
            TodoContext.SaveChanges();

            return item;
        }

        [HttpPut]
        [Route("{token}")]
        public IActionResult Update([FromRoute] string token, [FromBody] TodoListItem item)
        {
            var foundList = TodoContext.ListItems.FirstOrDefault(t => t.TodoList.Token == token && t.ListId == item.ListId);
            if (foundList == null)
            {
                return new HttpNotFoundResult();
            }

            foundList.LastModified = DateTime.Now;
            foundList.IsCompleted = item.IsCompleted;
            foundList.Item = item.Item;
            TodoContext.SaveChanges();

            return new EmptyResult();
        }

        [HttpDelete]
        [Route("{token}")]
        public void Remove([FromRoute] string token, [FromBody] TodoListItem item)
        {
            var foundList = TodoContext.ListItems.First(t => t.TodoList.Token == token);
            TodoContext.ListItems.Remove(foundList);

            TodoContext.SaveChanges();
        }
    }
}
