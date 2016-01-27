angular.module('todo', ['ngRoute'])
	.config(['$routeProvider', function ($routeProvider) {
	    $routeProvider
			.when('/:token?', {
			    controller: 'TodoController',
			    templateUrl: 'app/todo.template.htm'
			})
			.otherwise({
			    redirectTo: '/'
			});
	}]);