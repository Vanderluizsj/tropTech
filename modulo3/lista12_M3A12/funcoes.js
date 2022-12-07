
function Calculo(A, B, C) {
    return (A + B) * C - (C + A)/2;
}

const resultado = () => {
    return Calculo(3, 5, 4)
}


var imprimir = (function(){
   console.log('Resultado =', resultado())
})();
