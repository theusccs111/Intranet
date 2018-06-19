//controller de produtos

produtoAPP.controller('produtoCtrl', function ($scope, produtoService) {
    //carregando os produtos
    produtosList();


    function produtosList() {
        var listProdutos = produtoService.getTodosProdutos();

        listProdutos.then(function (d) {
            //se der certo
            $scope.Produtos = d.data;
        },//se nao der certo
            function () {
                alert("Ocorreu algum erro ao listar produtos");
            });
    }

  
    $scope.addProduto = function () {
        var produto = {
            Id: $scope.produto.Id,
            DescProduto: $scope.produto.DescProduto,
            Peso: $scope.produto.Peso,
            Valor: $scope.produto.Valor,
            Quantidade: $scope.produto.Quantidade,
            DataCompra: $scope.produto.DataCompra,
            DataVencimento: $scope.produto.DataVencimento
        };
        var addProduto = produtoService.addProduto(produto);

        addProduto.then(function (d) {
            if (d.data.success === true) {
                produtosList();
                alert("Produto Adicionado com Sucesso !");
                //delete $scope.produto;
            } else {
                alert("Produto não adicionado");
            }
        },
            function () {
                alert("Erro ocorrido ao tentar adcionar produto");
            });
    };

       
    
});