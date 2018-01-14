//define aplicação angular e o controller
var app = angular.module("categoriaApp", []);

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("Categoria", function ($scope, $http) {

    //$scope.ListaCategoria = [];

    //$http.get("Lista/")
    //   .success(function (data) {
    //       $scope.ListaCategoria = data;
    //   })
    //  .error(function (data) {
    //      console.log(data);
    //  });

    $scope.AddCategoria = function (categoria) {

        $("#mensagem").empty();
        $("#myModal").modal('show');

        $http.post('cadastrar/', { categoria: categoria })
        .success(function (result) {

            $("#mensagem").html(result);
            $("#myModal").modal('hide');

            //$scope.ListaCategoria.push($scope.categoria);

            delete $scope.categoria;
        })
        .error(function (data) {

            console.log(data);
            $("#myModal").modal('hide');
        });
    }

    $scope.ExcluirCategoria = function (id, nome) {
        var confirmar = confirm("Confirmar a exclusão da categoria " + nome);

        if (confirmar == true) {
            $http.post('excluir/', { id: id })
            .success(function (result) {

                $("#mensagem").html(result);
                $("#myModal").modal('hide');
            })
            .error(function (result) {

                console.log(result);
                $("#myModal").modal('hide');
            });
        }
    }
});