angular.module('todo')
	.controller('TodoController', ['$routeParams', 'TodoService', '$route', function($routeParams, TodoService, $route) {

        var app = this;

	    var getGuid = function () {
	        function s4() {
	            return Math.floor((1 + Math.random()) * 0x10000)
                  .toString(16)
                  .substring(1);
	        }
	        return s4() + s4() + '-' + s4() + '-' + s4() + '-' +
              s4() + '-' + s4() + s4() + s4();
	    };

	    app.addTodo = function (todoText) {
            var todo = { item: todoText, isCompleted: false, lastModified: new Date() };
            app.todos.push(todo);
            app.newTodo = '';
            TodoService.add(token, todo).then(function(data) {
                todo.listItemId = data.data.listItemId;
            });
        };

	    app.completeTodo = function (todo) {
            todo.isCompleted = !todo.isCompleted;
            TodoService.update(token, todo).then(function (data) {
               // nothing to do on success
            });
        };

	    app.deleteTodo = function (todo) {
            var index = app.todos.indexOf(todo);
            app.todos.splice(index, 1);
            TodoService.remove(token, todo).then(function (data) {
                // nothing to do on success
            });
        };

        var token = $routeParams.token || getGuid();
        if (!$routeParams.token) {
            $route.updateParams({ token: token });
        }

        TodoService.get(token).then(function(data) {
            app.todos = data.data.todoListItems;
        }, function(e) {
            app.todos = [];
        });

    }]);