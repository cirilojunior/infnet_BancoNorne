angular.module('contaApp', [])
  .controller('ContaController', function ($scope, $http) {

      $scope.tipos = ['Conta Poupança', 'Conta Corrente', 'Conta Eletrônica', 'Conta Salário', 'Conta Especial'];

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
              Cpf: $scope.contaModel.Cpf,
              cnpjFontePagadora: $scope.contaModel.cnpjFontePagadora,
              LimiteChequeEspecial: Number($scope.contaModel.LimiteChequeEspecial),
              Nome: $scope.contaModel.Nome,
              Identidade: $scope.contaModel.Identidade,
              rendaMensal: Number($scope.contaModel.rendaMensal),
              TelefonePrincipal: $scope.contaModel.TelefonePrincipal,
              TelefoneAlternativo: $scope.contaModel.TelefoneAlternativo,
              Email: $scope.contaModel.Email,
              Logradouro: $scope.contaModel.Logradouro,
              Numero: Number($scope.contaModel.Numero),
              Complemento: $scope.contaModel.Complemento,
              Cep: $scope.contaModel.Cep,
              Cidade: $scope.contaModel.Cidade

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
              Cpf: value.Cpf,
              cnpjFontePagadora: value.cnpjFontePagadora,
              LimiteChequeEspecial: value.LimiteChequeEspecial,
              Nome: value.Nome,
              Identidade: value.Identidade,
              rendaMensal: value.rendaMensal,
              TelefonePrincipal: value.TelefonePrincipal,
              TelefoneAlternativo: value.TelefoneAlternativo,
              Email: value.Email,
              Logradouro: value.Logradouro,
              Numero: value.Numero,
              Complemento: value.Complemento,
              Cep: value.Cep,
              Cidade: value.Cidade
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