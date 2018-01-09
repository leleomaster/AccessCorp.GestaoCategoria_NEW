//define aplicação angular e o controller
var app = angular.module("subCategoriaApp", []);
var indexCampoAdicionais = 0;
$(".div-texto-valor-campos").hide();

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("SubCategoria", function ($scope, $http, $compile, $httpParamSerializerJQLike) {

    $scope.camposAdicionais = "";
    $scope.SubCategoria = {};
    $scope.SubCategoria.CamposViewModel = [];

    $scope.SubCategoria.Nome = "";
    $scope.SubCategoria.Descricao = "";
    $scope.SubCategoria.Slug = "";
    $scope.ListaTipoCampo = [];
    $scope.ListaCategoria = [];

    //chama o  método IncluirProduto do controlador
    $scope.AddSubCategoria = function (subCategoria) {

        $scope.SubCategoria.Nome = subCategoria.Nome;
        $scope.SubCategoria.Descricao = subCategoria.Descricao;
        $scope.SubCategoria.Slug = subCategoria.Slug;
        $scope.SubCategoria.IdCategoria = subCategoria.IdCategoria;

        $http.post('cadastrar/', { subCategoria: $scope.SubCategoria })
        .success(function (result) {

            if (result === "TRUE") {
                alert("Cadastrado com sucesso!!!")
            }
            else {
                alert("Erro interno!!!")
            }
            delete $scope.SubCategoria;
        })
        .error(function (data) {
            console.log(data);
        });
    }

    $http.get("ListaTipocampo/").then(function (response) {
        $scope.ListaTipoCampo = response.data;
    })


    $http.get("ListaCategoria/").then(function (response) {
        $scope.ListaCategoria = response.data;
    });

    $scope.AddTextoCampoNgModel = function (TextoCampos) {

        if ($scope.camposViewModel.TextoCampos == undefined) {
            $scope.camposViewModel.TextoCampos = [];
        }

        $scope.camposViewModel.TextoCampos.push(TextoCampos);

        delete $scope.TextoCampos;
    }

    $scope.AddCampoNgModel = function (camposViewModel) {

        if (camposViewModel.TextoCampos == undefined) {
            camposViewModel.TextoCampos = [];
        }

        $scope.SubCategoria.CamposViewModel.push($scope.camposViewModel);

        addCamposAdicionaisNaTabela(indexCampoAdicionais, $compile, $scope);

        delete $scope.camposViewModel;

        indexCampoAdicionais++;
    }

    $scope.RemoveCampo = function (index) {
        var ehParaRemover = confirm("Você tem certeza que deseja remover essas campos?");

        if (ehParaRemover) {
            $scope.SubCategoria.CamposViewModel.splice(index, 1);
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


function addCamposAdicionaisNaTabela(index, $compile, $scope) {

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