//define aplicação angular e o controller
var app = angular.module("subCategoriaApp", []);
var indexCampoAdicionais = 0;
$(".div-texto-valor-campos").hide();

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("SubCategoria", function ($scope, $http, $compile) {

    $scope.ListaCategoria = [];
    $scope.ListaTipoCampo = [];
    $scope.camposAdicionais = "";
    $scope.tempPage = "";
    $scope.subCategoria = [];
    $scope.subCategoria.camposViewModel = [];
    $scope.subCategoria.camposViewModel.TextoCampos = [];
    $scope.camposViewModel = [];

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

    $scope.AddCampoNgModel = function (camposViewModel) {

        $scope.subCategoria.camposViewModel.push(camposViewModel);

        addCamposAdicionaisNaTaebla(indexCampoAdicionais, $compile, $scope);

        $scope.camposViewModel.Obrigatorio = false;
        $scope.camposViewModel.Ordem = "";
        $scope.camposViewModel.IdTipoCampo = 0;

        indexCampoAdicionais++;
    }

    $scope.RemoveCampo = function (index) {
        var ehParaRemover = confirm("Você tem certeza que deseja remover essas campos?");

        if (ehParaRemover) {
            $scope.subCategoria.camposViewModel.splice(index, 1);
            removerCamposAdicionaisNaTaebla(index);
            indexCampoAdicionais--;
        }
    }

    $scope.esconderOuMostrarCampos = function () {
        var idTipoCampo = $scope.camposViewModel.IdTipoCampo;

        if (idTipoCampo == 6) {// select/combobox
            $(".div-texto-valor-campos").show();
        } else {
            $(".div-texto-valor-campos").hide();
        }
    }
});

function addCamposAdicionaisNaTaebla(index, $compile, $scope) {

    var obrigatorio = $('input#idTextoObrigatorio').is(':checked') == true ? "Sim" : "Não";
    var tr =
            "<tr id=tr_" + index + ">" +
                "<td>" + obrigatorio + "</td>" +
                "<td>" + $("#idOrdem").val() + "</td>" +
                "<td>" + $("#IdTipoCampo option:selected").text() + "</td>" +
                "<td><button class='btn btn-dange' ng-click='RemoveCampo(" + index + ")'>X</button></td>" +
    "</tr>";

    var el = $compile(tr)($scope);

    $("#idCamposAdicionados > table > tbody").append(el);


}

function removerCamposAdicionaisNaTaebla(index) {
    $("#tr_" + index).remove();
}