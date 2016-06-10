angular.module('contaApp', [])
  .controller('ContaController', function ($scope, $http) {

      $scope.tipos = ['Conta Poupança', 'Conta Corrente', 'Conta Eletrônica','Conta Salário', 'Conta Especial'];

      //POUPANCA, CORRENTE, ELETRONICA, SALARIO, ESPECIAL_ELETRONICA
      $scope.isCNPJ = false;
      $scope.isEspecial = false;
      $scope.isListar = true;
      $scope.contaModel = {};
      $scope.contas = [];
      $scope.tipoConta = {};

      $scope.listarContas = function () {
          $scope.isListar = true;
          $scope.isCNPJ = false;
          $scope.isEspecial = false;
          $http.get('http://localhost:57339/api/Conta').success(function (data) {
              $scope.contas = data;
          })
      }

      $scope.iniciarCriacao = function () {
          $scope.isListar = false;
      }

      $scope.abrirConta = function (value) {       


          var novaConta = {
              codigoConta: Math.random(),
              Tipo: 1,
              SituacaoCriacao: 0,
              Situacao: 0,
              Saldo: 0,
              cnpj: $scope.contaModel.cnpj,
              LimiteChequeEspecial: Number($scope.contaModel.LimiteChequeEspecial)
          }

          $http.post('http://localhost:57339/api/Conta', novaConta).success(function (data) {
              $scope.listarContas();
          })
      }

      $scope.contaTipoChangeHandler = function (itemSelecionado) {
          $scope.isCNPJ = false;
          $scope.isEspecial = false;
          if (itemSelecionado == 'Conta Salário') {
              $scope.isCNPJ = true;
          } else if (itemSelecionado == 'Conta Especial') {
              $scope.isEspecial = true;
          } else {
              $scope.isCNPJ = false;
              $scope.isEspecial = false;
          }
      }


      $scope.aprovarConta = function (value, index) {
         
          var novaConta = {
              codigoConta: value.codigoConta,
              Tipo: value.Tipo,
              SituacaoCriacao: 1,
              Situacao: value.Situacao,
              Saldo: value.Saldo,
              cnpj: $scope.contaModel.cnpj,
              LimiteChequeEspecial: Number($scope.contaModel.LimiteChequeEspecial)
          }

          $http.put('http://localhost:57339/api/Conta/1', novaConta).success(function (data) {
              $scope.listarContas();
          })
      }

      $scope.listarContas();
  });