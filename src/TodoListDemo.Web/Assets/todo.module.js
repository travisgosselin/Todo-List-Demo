angular.module('todo', ['ngRoute'])
	.config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/:token?', {
                controller: 'TodoController',
                controllerAs: 'app',
			    templateUrl: 'assets/app/todo.template.htm'
			})
			.otherwise({
			    redirectTo: '/'
			});
	}]);