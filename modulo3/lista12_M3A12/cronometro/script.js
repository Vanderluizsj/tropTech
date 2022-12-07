var pausa = false;

function pausar() {
    pausa=true;
}
var cronometro = () => {
    var tempo = 60;

    var intervalo = setInterval(() =>{
        var novoTempo = tempo - 1;

        tempo = novoTempo;

        document.querySelector('#segundos').innerHTML = `${tempo} segundos...`;

        
        if(novoTempo === 0 || pausa==true){
            clearInterval(intervalo);
        }
    }, 1000)
}

cronometro();    


