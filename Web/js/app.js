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
              Tipo: buscarTipoConta(),
              SituacaoCriacao: 0,
              Situacao: 0,
              Saldo: 0,
              cnpjFontePagadora: $scope.contaModel.cnpjFontePagadora,
              LimiteChequeEspecial: Number($scope.contaModel.LimiteChequeEspecial),
              nomeCliente: $scope.contaModel.nomeCliente,
              cpf: $scope.contaModel.cpf
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
              cnpjFontePagadora: value.cnpjFontePagadora,
              LimiteChequeEspecial: value.LimiteChequeEspecial,
              nomeCliente: value.nomeCliente,
              cpf: value.cpf
          }

          $http.put('http://localhost:57339/api/Conta/1', novaConta).success(function (data) {
              $scope.listarContas();
          })
      }

      function buscarTipoConta() {
          if ($scope.contaModel.tipoString == 'Conta Poupança') {
              return 0;
          } else if ($scope.contaModel.tipoString == 'Conta Corrente') {
              return 1;
          } else if ($scope.contaModel.tipoString == 'Conta Eletrônica') {
              return 2;
          } else if ($scope.contaModel.tipoString == 'Conta Salário') {
              return 3;
          } else if ($scope.contaModel.tipoString == 'Conta Especial') {
              return 4;
          }
      }


      $scope.listarContas();
  });