using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity.Storage;


namespace TodoListDemo.Data
{
    public static class SampleData
    {
        public static void Inititalize(IServiceProvider serviceProvider)
        {
            return;

            var context = serviceProvider.GetService<TodoListContext>();
            if (!context.Lists.Any())
            {
                var list = new TodoList {Token = Guid.NewGuid().ToString()};
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

                context.SaveChanges();
            }
        }
    }
}
