//define aplicação angular e o controller
var app = angular.module("categoriaApp", []);

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("Categoria", function ($scope, $http) {

    //chama o  método IncluirProduto do controlador
    $scope.AddCategoria = function (categoria) {
        $http.post('/categoria/cadastrar/', { categoria: categoria })
        .success(function (result) {
            $scope.produtos = result;
            delete $scope.produto;
        })
        .error(function (data) {
            console.log(data);
        });
    }

    //chama o método AtualizarCategoria do controlador
    $scope.AtualizarCategoria = function (categoria) {
        $http.post('/categoria/atualizar/', { categoria: categoria })
        .success(function (result) {
            $scope.produtos = result;
        })
        .error(function (data) {
            console.log(data);
        });
    }
});