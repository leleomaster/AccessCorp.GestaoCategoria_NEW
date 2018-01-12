//define aplicação angular e o controller
var app = angular.module("categoriaApp", []);

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("Categoria", function ($scope, $http) {

    //chama o  método IncluirProduto do controlador
    $scope.AddCategoria = function (categoria) {

        $("#mensagem").empty();
        $("#myModal").modal('show');

        $http.post('cadastrar/', { categoria: categoria })
        .success(function (result) {

            $("#mensagem").html(result);
            $("#myModal").modal('hide');
            delete $scope.categoria;
        })
        .error(function (data) {

            console.log(data);
            $("#myModal").modal('hide');
        });
    }
});