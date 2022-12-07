var produtos = "REFRIGERANTE,CERVEJA,CARNE,SABÃO,BALA,IOGURTE,MARCARRÃO,CEBOLA,MAÇÃ,AMACIANTE";
var arrayProdutos = produtos.split(",");
console.log(arrayProdutos);

function filterItems(query) {
    return arrayProdutos.filter(function(el) {
        return el.toLowerCase().indexOf(query.toLowerCase()) == 0;
    })
  }
  var produtosComC = filterItems('C'); 
  console.log(produtosComC);

  console.log(filterItems('CERVEJA'), '=> INDEX =', arrayProdutos.indexOf('CERVEJA'))
  console.log(filterItems('CARNE'), '=> INDEX =', arrayProdutos.indexOf('CARNE'))
  console.log(filterItems('MAÇÃ'), '=> INDEX =', arrayProdutos.indexOf('MAÇÃ'))
  console.log(filterItems('AMACIANTE'), '=> INDEX =', arrayProdutos.indexOf('AMACIANTE'))