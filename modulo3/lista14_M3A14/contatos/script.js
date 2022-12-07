const form = document.getElementById("formContato");
const table = document.getElementById("tableAluno");

const inputNome = document.getElementById('nome');
const inputTelefone = document.getElementById('telefone');

const manipulador = (evento) => {
    // para não dar refresh
    evento.preventDefault();
    const aluno = {
        nome: inputNome.value,
        telefone: inputTelefone.value,
        status: 'pendente',
    };
    adicionarTabela(aluno);
}

const adicionarTabela = (aluno) => {
    const novaLinha = document.createElement('tr');

    const colunaNome = document.createElement('td');
    colunaNome.textContent = aluno.nome;
    novaLinha.appendChild(colunaNome);

    const colunaTelefone = document.createElement('td');
    colunaTelefone.textContent = aluno.telefone;
    novaLinha.appendChild(colunaTelefone);

    const colunaStatus = document.createElement('td');
    colunaStatus.textContent = aluno.status;
    novaLinha.appendChild(colunaStatus);

    table.getElementsByTagName('tbody')[0].appendChild(novaLinha);
};

form.addEventListener("submit", manipulador);


const manipuladorStatus = (evento) => {
    if (evento.target.tagName === 'TD') {
        const linha = evento.target.parentElement;
        linha.classList = ' feito';
        const colunaStatus = linha.querySelector('td:last-child');
        colunaStatus.textContent = 'feito';
    }
}
// usamos event bubbling para não precisar definir para cada td
table.addEventListener('click', manipuladorStatus);