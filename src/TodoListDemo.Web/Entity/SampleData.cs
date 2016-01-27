using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace TodoListDemo.Web.Entity
{
    public static class SampleData
    {
        public static void Inititalize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<TodoListContext>();
            if (!context.Lists.Any())
            {
                var list = new TodoList
                {
                    Token = Guid.NewGuid().ToString()
                };
                list.TodoListItems.AddRange(new List<TodoListItem> { 
                    new TodoListItem()
                    {
                        LastModified = DateTime.Now,
                        IsCompleted = false,
                        Item = "Test this app!"
                    },
                    new TodoListItem()
                    {
                        LastModified = DateTime.Now,
                        IsCompleted = false,
                        Item = "Can you even mark this completed?"
                    }});

                context.Lists.Add(list);
                context.SaveChanges();
            }
        }
    }
}
