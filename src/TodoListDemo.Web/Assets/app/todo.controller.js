angular.module('todo')
	.controller('TodoController', ['$scope', '$routeParams', '$filter', function($scope, $routeParams, $filter) {
        
        $scope.addTodo = function(todoText) {
            $scope.todos.push({ text: todoText, isComplete: false });
            $scope.newTodo = '';
        }

        $scope.completeTodo = function(todo) {
            todo.isComplete = !todo.isComplete;
        };

        $scope.deleteTodo = function(todo) {
            var index = $scope.todos.indexOf(todo);
            $scope.todos.splice(index, 1);
        };

    }]);