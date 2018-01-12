//define aplicação angular e o controller
var app = angular.module("categoriaApp", []);

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("Categoria", function ($scope, $http) {

    //chama o  método IncluirProduto do controlador
    $scope.AddCategoria = function (categoria) {

        $("#mensagem").empty();

        $http.post('cadastrar/', { categoria: categoria })
        .success(function (result) {
            
            $("#mensagem").html(result);

            delete $scope.categoria;
        })
        .error(function (data) {
            //error
            alert("Error")
        });
    }

    //chama o método AtualizarCategoria do controlador
    $scope.AtualizarCategoria = function (categoria) {
        $http.post('atualizar/', { categoria: categoria })
        .success(function (result) {

            delete $scope.categoria;
        })
        .error(function (data) {
            console.log(data);
        });
    }
});