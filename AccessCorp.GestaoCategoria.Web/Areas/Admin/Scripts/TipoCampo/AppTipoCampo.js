//define aplicação angular e o controller
var app = angular.module("tipoCampoApp", []);

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("TipoCampo", function ($scope, $http) {

    //chama o  método IncluirProduto do controlador
    $scope.AddTipoCampo = function (tipoCampo) {
        $http.post('cadastrar/', { tipoCampo: tipoCampo })
        .success(function (result) {
            $scope.produtos = result;
            delete $scope.produto;
        })
        .error(function (data) {
            console.log(data);
        });
    }

    //chama o método AtualizarCategoria do controlador
    $scope.AtualizarCategoria = function (tipoCampo) {
        $http.post('atualizar/', { tipoCampo: tipoCampo })
        .success(function (result) {
            $scope.produtos = result;
        })
        .error(function (data) {
            console.log(data);
        });
    }
});