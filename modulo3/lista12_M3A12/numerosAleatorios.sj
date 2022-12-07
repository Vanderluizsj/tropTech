//Questão 2
var numerosAleatorios = [12, 45, 55, 65, 77, 98, 43, 33, 28, 61, 75]

var impar = numerosAleatorios.filter((numero)=>{
    return (numero%2) != 0;
})
var par =  numerosAleatorios.filter((numero)=>{
    return (numero%2) == 0;
})
console.log('impar', impar)
console.log('par', par)

numerosAleatorios.forEach(element => {
    if(element > 50){
      console.log('maior que 50 = ', element)
      }
});
const listaOrdenada = numerosAleatorios.sort()
console.log('lista ordenada', listaOrdenada)

var arrayComMap = numerosAleatorios.map((numero) => {

    if(numero < 70){
    return 0
    }
    return numero;
})

console.log('array com map', arrayComMap)

console.log('Numero encontrado(find) ', numerosAleatorios.find((numero)=>numero==98))

