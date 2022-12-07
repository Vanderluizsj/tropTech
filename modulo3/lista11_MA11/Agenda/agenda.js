var array = [];

function adicionarContato(){
    var primeiroNome = document.querySelector('#primeiroNome').value;
    var sobrenome = document.querySelector('#sobrenome').value;
    var telefone = document.querySelector('#telefone').value;
    var contato = 
    {
        primeiroNome: primeiroNome,
        sobrenome: sobrenome,
        telefone: telefone
    }
    
    array.push(contato);
    this.atualizarLista();
}

function removerContato(){
    array.pop();
    this.atualizarLista();
}

function atualizarLista(){
    document.querySelector('h6').innerText = '';

    for (let index = 0; index < array.length; index++) {
        document.querySelector('h6').innerHTML += `<br> [${index}]: ${array[index].primeiroNome} ${array[index].sobrenome} - Telefone: ${array[index].telefone}`;
    }
}

