angular.module('todo', ['ngRoute'])
	.config(['$routeProvider', function ($routeProvider) {
	    $routeProvider
			.when('/', {
			    controller: 'TodoController',
			    templateUrl: 'app/todo.template.htm'
			})
			.otherwise({
			    redirectTo: '/'
			});
	}]);