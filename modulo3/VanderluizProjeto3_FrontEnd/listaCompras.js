var listaProdutos = [];

//--------------adicionar produto na lista-------------
function adicionarProduto(){
    var nome = document.querySelector('#nomeProduto').value;
    var preco = document.querySelector('#precoProduto').value;
    var quantidade = document.querySelector('#quantidadeProduto').value;
    var produto =
    {
        nomeProduto: nome,
        precoProduto: preco,
        quantidadeProduto: quantidade
    }
    listaProdutos.push(produto)
    this.atualizarLista();
}
//-----------------add botao-------------------
function createButton()
{
     var btn = document.createElement('BUTTON');
     var lbl = document.createTextNode("Remover");
     btn.setAttribute('class', 'btn btn-danger mt-2 md-2');      
     btn.appendChild(lbl);

     btn.onclick = function()
     {
        removerProduto();
     }
     document.querySelector('h6').appendChild(btn);    
}

//-------------remover itens----------------
function removerProduto(){
    listaProdutos.pop();
    this.atualizarLista();
}
//--------------------------------------------



function atualizarLista(){
    document.querySelector('h6').innerText = '';

    for (let index = 0; index < listaProdutos.length; index++) 
    {
        document.querySelector('h6').innerHTML += `</br> [${index}]: Produto: ${listaProdutos[index].nomeProduto}  -  Valor: R$ ${listaProdutos[index].precoProduto}  -  Quantidade: ${listaProdutos[index].quantidadeProduto}     `, createButton() 
    }
        
}
