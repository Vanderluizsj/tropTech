const salvarContato = document.getElementById("salvar");

function erro() {
    const form = document.getElementById('some-form')
    form.addEventListener('submit', e => {
        e.preventDefault()
        console.log('Deu certo')
        
    }) 
}

const manipulador = function () {    
    let sobrenome = document.getElementById('sobrenome');
    let email = document.getElementById('email');
    let celular = document.getElementById('celular');
    let nascimento = document.getElementById('dataNascimento');
    let nome = document.getElementById('nome');
    let feedback = document.getElementById('feedback');

    
    if (nome.value == '' || sobrenome.value == '' || email.value == '' || celular.value == '' || nascimento.value =='') {
        erro()
        nome.setAttribute ('class', 'form-control is-invalid');
        sobrenome.setAttribute ('class', 'form-control is-invalid');
        email.setAttribute ('class', 'form-control is-invalid');
        celular.setAttribute ('class', 'form-control is-invalid');
        nascimento.setAttribute ('class', 'form-control is-invalid');
        feedback.setAttribute('class','text-danger mb-4')
            
        feedback.innerText = 'Preencha todos os campos!';
    } else {
        nome.setAttribute ('class', 'form-control is-valid');
        sobrenome.setAttribute ('class', 'form-control is-valid');
        email.setAttribute ('class', 'form-control is-valid');
        celular.setAttribute ('class', 'form-control is-valid');
        nascimento.setAttribute ('class', 'form-control is-valid');
        feedback.setAttribute('class','text-success mb-4');
        feedback.innerText = 'Formulario preenchido com sucesso!';
        setInterval(() => {return window.location.reload();}, 3000);        
    }
     
};
salvarContato.addEventListener("click", manipulador)