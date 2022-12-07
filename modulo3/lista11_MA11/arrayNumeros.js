var numeros = new Array(100)

for (let index = 1; index <= 100; index++) {
    numeros.push(index)    
}
for (let index = 1; index <= numeros.length; index++) {
    console.log(numeros[index])    
}

for (let index = 1; index <= numeros.length; index++) {
    const impar = [];
    if (numeros[index]%2!=0) {
        impar[index] = numeros[index] 
        console.log(impar[index]) 
    }
    
}
