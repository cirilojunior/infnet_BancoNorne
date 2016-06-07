angular.module('contaApp', [])
  .controller('ContaController', function ($scope, $http) {

      $scope.contaModel = {};
      $scope.contas = [];

      $scope.listarContas = function () {
          $http.get('http://localhost:57339/api/Conta').success(function (data) {
              $scope.contas = data;
          })
      }

      $scope.criarConta = function (value) {

          var novaConta = {
              "idConta": 6,
              "Tipo": 1,
              "SituacaoCriacao": 0,
              "Situacao": 0,
              "Saldo": 0
          }

          $http.post('api/Conta', novaConta).success(function (data) {
              $scope.listarContas();
          })
      }

      $scope.aprovarConta = function (value) {

          var novaConta = {
              "idConta": 6,
              "Tipo": 1,
              "SituacaoCriacao": 0,
              "Situacao": 0,
              "Saldo": 0
          }

          $http.put('api/Conta', novaConta).success(function (data) {
              $scope.listarContas();
          })
      }


      /*var todoList = this;
      todoList.todos = [
        { text: 'learn angular', done: true },
        { text: 'build an angular app', done: false }];

      todoList.addTodo = function () {
          todoList.todos.push({ text: todoList.todoText, done: false });
          todoList.todoText = '';
      };

      todoList.remaining = function () {
          var count = 0;
          angular.forEach(todoList.todos, function (todo) {
              count += todo.done ? 0 : 1;
          });
          return count;
      };

      todoList.archive = function () {
          var oldTodos = todoList.todos;
          todoList.todos = [];
          angular.forEach(oldTodos, function (todo) {
              if (!todo.done) todoList.todos.push(todo);
          });
      };*/


      $scope.listarContas();
  });