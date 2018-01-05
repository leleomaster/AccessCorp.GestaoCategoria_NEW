//define aplicação angular e o controller
var app = angular.module("subCategoriaApp", []);

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("SubCategoria", function ($scope, $http, $compile) {

    $scope.ListaCategoria = [];
    $scope.ListaTipoCampo = [];
    $scope.camposAdicionais = "";
    $scope.tempPage = "";
    $scope.subCategoria = [];

    //chama o  método IncluirProduto do controlador
    $scope.AddSubCategoria = function (subCategoria) {
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
        .then(function (response) {
            $scope.produtos = response.data;
        });
    }

    $http.get("ListaCategoria").then(function (response) {
        $scope.ListaCategoria = response.data;
    });

    $http.get("ListaTipoCampo").then(function (response) {
        $scope.ListaTipoCampo = response.data;
    })



    $http.get('CamposAdicionais/')
       .then(function (response) {
           $scope.tempPage = response.data;
       })


    $scope.AddCamposTela = function () {

        var el = $compile($scope.tempPage)($scope);
        $('#idCamposAdicionais').append(el);
    }

    $scope.AddCampoNgModel = function (campos) {
        $scope.subCategoria.push(campos);
    }
});
