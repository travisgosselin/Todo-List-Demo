using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TodoListDemo.Web.Entity;

namespace TodoListDemo.Web.Services
{
    [Route("api/todo")]
    public class TodoController : Controller
    {
        [Route("api/todo/{token}")]
        public TodoList Get(string token)
        {
            return new TodoList();
        }

        [Route("api/todo")]
        public void Post(TodoList todoList)
        {
        }

        [Route("api/todo")]
        public void Put(TodoList todoList)
        {
        }

        [Route("api/todo/{token}")]
        public void Delete(string token)
        {
        }
    }
}
