angular.module('contaApp', [])
  .controller('ContaController', function ($scope, $http) {

      $scope.tipos = ['Conta Poupança', 'Conta Corrente', 'Conta Eletrônica','Conta Salário', 'Conta Especial'];

      //POUPANCA, CORRENTE, ELETRONICA, SALARIO, ESPECIAL_ELETRONICA

      $scope.isListar = true;
      $scope.contaModel = {};
      $scope.contas = [];
      $scope.tipoConta = {};

      $scope.listarContas = function () {
          $scope.isListar = true;
          $http.get('http://localhost:57339/api/Conta').success(function (data) {
              $scope.contas = data;
          })
      }

      $scope.iniciarCriacao = function () {
          $scope.isListar = false;
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

      $scope.aprovarConta = function (value, index) {

          alert(value);
          /*
          var novaConta = {
              "idConta": 6,
              "Tipo": 1,
              "SituacaoCriacao": 0,
              "Situacao": 0,
              "Saldo": 0
          }

          $http.put('api/Conta', novaConta).success(function (data) {
              $scope.listarContas();
          })*/
      }

      $scope.listarContas();
  });