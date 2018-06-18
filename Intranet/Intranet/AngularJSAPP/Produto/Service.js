//vai carregar os dados via http.get do mvc controler

produtoAPP.service('produtoService', function ($http) {


    this.getTodosProdutos = function () {
        return $http.get("/Produto/GetProdutos");
    }

    this.addProduto = function (produto) {
        var request = $http({
            method: 'post',
            url: '/Produto/AddProduto',
            data: produto
        });

        return request;
    }
});