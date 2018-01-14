//define aplicação angular e o controller
var app = angular.module("subCategoriaApp", []);
var indexCampoAdicionais = 0;
$(".div-texto-valor-campos").hide();

//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller("SubCategoria", function ($scope, $http, $compile, $httpParamSerializerJQLike) {

    $scope.AddSubCategoria = function (subCategoria) {

        $scope.SubCategoria.Nome = subCategoria.Nome;
        $scope.SubCategoria.Descricao = subCategoria.Descricao;
        $scope.SubCategoria.Slug = subCategoria.Slug;
        $scope.SubCategoria.IdCategoria = subCategoria.IdCategoria;
        
        $("#mensagem").empty();
        $("#myModal").modal('show');

        $http.post('cadastrar/', { subCategoria: $scope.SubCategoria })
        .success(function (result) {

            $("#mensagem").html(result);
            $("#myModal").modal('hide');

            delete $scope.SubCategoria;

            inicializarObjectos();
        })
        .error(function (data) {
            console.log(data);
            $("#myModal").modal('hide');
        });
    }

    $http.get("ListaTipocampo/")
    .success(function (data) {
        $scope.ListaTipoCampo = data;
    })
     .error(function (data) {
         console.log(data);
     });

    $http.get("ListaCategoria/")
       .success(function (data) {
            $scope.ListaCategoria = data;
       })
      .error(function (data) {
          console.log(data);
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

    var inicializarObjectos = function () {
        $scope.camposAdicionais = "";
        $scope.SubCategoria = {};
        $scope.SubCategoria.CamposViewModel = [];

        $scope.SubCategoria.Nome = "";
        $scope.SubCategoria.Descricao = "";
        $scope.SubCategoria.Slug = "";
        $scope.ListaTipoCampo = [];
        $scope.ListaCategoria = [];
    };
    inicializarObjectos();
});


function addCamposAdicionaisNaTabela(index, $compile, $scope) {

    var obrigatorio = $('input#idTextoObrigatorio').is(':checked') == true ? "Sim" : "Não";
    var tr =
            "<tr id=tr_" + index + ">" +
                "<td>" + $("#idDescricaoCampo").val() + "</td>" +
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