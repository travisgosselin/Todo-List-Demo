angular.module('todo')
	.factory('TodoService', ['$http', function ($http) {
        var baseUrl = 'api/todo';
	    return {
            get: function(token) {
                return $http.get(baseUrl + "/" + token);
            },
	        add: function(token, todoItem) {
	            return $http.post(baseUrl + "/" + token, todoItem);
	        },
            update: function(token, todoItem) {
                return $http.put(baseUrl + "/" + token, todoItem);
            },
            remove: function(token, todoItem) {
                return $http.delete(baseUrl + "/" + token, todoItem);
            }
	    }
	}]);