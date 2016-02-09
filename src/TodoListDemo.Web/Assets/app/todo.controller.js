angular.module('todo')
	.controller('TodoController', ['$scope', '$routeParams', 'TodoService', '$route', function($scope, $routeParams, TodoService, $route) {
        
	    var getGuid = function () {
	        function s4() {
	            return Math.floor((1 + Math.random()) * 0x10000)
                  .toString(16)
                  .substring(1);
	        }
	        return s4() + s4() + '-' + s4() + '-' + s4() + '-' +
              s4() + '-' + s4() + s4() + s4();
	    };

        $scope.addTodo = function(todoText) {
            var todo = { item: todoText, isCompleted: false, lastModified: new Date() };
            $scope.todos.push(todo);
            $scope.newTodo = ''; 
            TodoService.add(token, todo).then(function(data) {
                todo.listItemId = data.data.listItemId;
            });
        };

        $scope.completeTodo = function(todo) {
            todo.isCompleted = !todo.isCompleted;
            TodoService.update(token, todo).then(function (data) {
               // nothing to do on success
            });
        };

        $scope.deleteTodo = function(todo) {
            var index = $scope.todos.indexOf(todo);
            $scope.todos.splice(index, 1);
            TodoService.remove(token, todo).then(function (data) {
                // nothing to do on success
            });
        };

        var token = $routeParams.token || getGuid();
        if (!$routeParams.token) {
            $route.updateParams({ token: token });
        }

        TodoService.get(token).then(function(data) {
            $scope.todos = data.data.todoListItems;
        }, function(e) {
            $scope.todos = [];
        });

    }]);