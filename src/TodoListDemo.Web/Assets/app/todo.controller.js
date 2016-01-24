angular.module('todo')
	.controller('TodoController', ['$scope', '$routeParams', '$filter', function($scope, $routeParams, $filter) {
        $scope.test = 'hello2';
    }]);