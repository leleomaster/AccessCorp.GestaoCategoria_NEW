//define aplicação angular e o controller
var app = angular.module("categoriaApp", []);

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("Categoria", function ($scope, $http) {

    //chama o  método IncluirProduto do controlador
    $scope.AddCategoria = function (categoria) {
        $http.post('cadastrar/', { categoria: categoria })
        .then(function (result) {

            if (result === "TRUE") {
                alert("Cadastrado com sucesso!!!")
            }
            else {
                alert("Erro interno!!!")
                console.log(result);
            }

            delete $scope.categoria;
        })
    }

    //chama o método AtualizarCategoria do controlador
    $scope.AtualizarCategoria = function (categoria) {
        $http.post('atualizar/', { categoria: categoria })
        .success(function (result) {
            if (result === "TRUE") {
                alert("Atualizado com sucesso!!!")
            }
            else {
                alert("Erro interno!!!")
            }

            delete $scope.categoria;
        })
        .error(function (data) {
            console.log(data);
        });
    }
});