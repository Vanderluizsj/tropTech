var primeiroNumero = document.querySelector("#primeiroNumero");
var segundoNumero = document.querySelector("#segundoNumero");


function calcular() {
    let seletor = document.getElementById("operacao")
    let opcao = seletor.options[seletor.selectedIndex].value
    
    switch (opcao) {
        case "Somar":
            somar()
            break;
        case "Subtrair":
            subtrair()
            break;
        case "Multiplicar":
            multiplicar()
            break;
        case "Dividir":
            dividir()
            break;    
        default:
            console.error("Valor inesperado!");
            break;
    }
}
function somar() {
    document.querySelector("#Resultado").innerText = (Number(primeiroNumero.value) + Number(segundoNumero.value));
}
function subtrair(){
    document.querySelector("#Resultado").innerText = (Number(primeiroNumero.value) - Number(segundoNumero.value));
}

function dividir(){
    document.querySelector("#Resultado").innerText = (Number(primeiroNumero.value) / Number(segundoNumero.value));
}

function multiplicar(){
    document.querySelector("#Resultado").innerText = (Number(primeiroNumero.value) * Number(segundoNumero.value));
}

function potencia(){
    document.querySelector("#Resultado").innerText = (Number(primeiroNumero.value) ** Number(segundoNumero.value));
}
function limpar() {
    document.querySelector("#Resultado").innerText = ("");
    document.querySelector("#primeiroNumero").value='';
    document.querySelector("#segundoNumero").value='';
}

function validar(){
    console.log("chamado validar ok!")
    let nome = document.getElementById("nome").value
    let idade = document.getElementById("idade").value
    let cpf = document.getElementById("cpf").value
    
    if (nome.length < 6) {
        document.getElementById("mensagem").innerHTML =("O campo nome deve ter no mínimo 6 caracteres!")
        document.getElementById("mensagem").style.color = 'red'
    } else if(idade<1 || idade>130)
    {
        document.getElementById("mensagem").innerHTML =("A idade tem de ser maior que 0 e menor que 130!")
        document.getElementById("mensagem").style.color = 'red'
    } else if(cpf.length<11)
    {
        document.getElementById("mensagem").innerHTML =("O campo cpf deve ter 11 caracteres!")
        document.getElementById("mensagem").style.color = 'red'
    }else{
        document.getElementById("mensagem").innerHTML =("Tudo certo")
        document.getElementById("mensagem").style.color = 'green'
    }
}