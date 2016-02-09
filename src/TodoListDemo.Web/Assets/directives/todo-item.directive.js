angular.module('todo')
    .directive('todoItem', function () {
        return {
            scope: {
                todo: '=todoItem',
                todoDelete: '&',
                todoComplete: '&'
            },
            template: '<div class="card card-inverse card-primary text-xs-center">' + 
                      '  <div class="card-block">' + 
                      '      <blockquote class="card-blockquote">' + 
                      '          <footer>{{ todo.lastModified | date:\'short\' }}</footer>' + 
                      '          <p class="card-text" ng-class="{ \'strike\': todo.isCompleted }">{{ todo.item }}</p>' + 
                      '      </blockquote>' + 
                      '      <div class="manage-buttons">' + 
                      '          <button type="button" class="btn btn-success-outline" ng-class="{ \'btn-warning-outline\': todo.isCompleted, \'btn-success-outline\': !todo.isCompleted, }" ng-click="todoComplete({ todo: todo })">{{ todo.isComplete ? \'Not Done\' : \'Complete\' }}</button>' +
                      '          <button type="button" class="btn btn-danger-outline" ng-click="todoDelete({ todo: todo })">Delete</button>' + 
                      '      </div>' + 
                      '  </div>' +
                      '</div>'
        };
    });