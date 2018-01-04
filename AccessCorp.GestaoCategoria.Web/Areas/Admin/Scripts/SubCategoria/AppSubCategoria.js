//define aplicação angular e o controller
var app = angular.module("subCategoriaApp", []);

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("SubCategoria", function ($scope, $http) {

    //chama o  método IncluirProduto do controlador
    $scope.AddCategoria = function (subCategoria) {
        $http.post('cadastrar/', { subCategoria: subCategoria })
        .success(function (result) {
            $scope.produtos = result;
            delete $scope.produto;
        })
        .error(function (data) {
            console.log(data);
        });
    }

    //chama o método AtualizarCategoria do controlador
    $scope.AtualizarCategoria = function (subCategoria) {
        $http.post('atualizar/', { subCategoria: subCategoria })
        .success(function (result) {
            $scope.produtos = result;
        })
        .error(function (data) {
            console.log(data);
        });
    }


    $http.get("listar").success(function (response) {
        $scope.ListaCategoria = response.data;
    })
   .error(function () {
       alert("Error")
   });
});
