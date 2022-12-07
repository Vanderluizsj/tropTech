console.log("Introdução ao JS!")
console.log("1 - Variáveis")
console.log("1.1 - Aluno")

var Nome = 'Luiz'
var Idade = 33
var Ativo = true
var DataDeNascimento = new Date(2000, 01, 01)
var Matricula = 2314
var Universidade = 'IFSC'
var Altura = 1.82
var Peso = 95.5

console.log(Nome)
console.log(Idade)
console.log(Ativo)
console.log(DataDeNascimento)
console.log(Matricula)
console.log(Universidade)
console.log(Altura)
console.log(Peso)

console.log("--------------------------------------")
console.log("1.2 - Produto")

var Nome = 'Arroz'
var Descricao = 'Tipo 1'
var Preco = 15.99
var DataDeValidade = new Date(2022, 12, 20)
var Codigo = 12421
var QuantidadeEstoque = 15
var Fornecedor = 'Urbano'
var ExisteNoEstoque = true

console.log(Nome)
console.log(Descricao)
console.log(Preco)
console.log(DataDeValidade)
console.log(Codigo)
console.log(QuantidadeEstoque)
console.log(Fornecedor)
console.log(ExisteNoEstoque)

console.log("--------------------------------------")
console.log("1.3 - Carro")

var Nome = 'G5'
var Modelo = 'Gol'
var Placa = 'a23dr1'
var Ano_fabricacao = 2012 
var Ano_modelo = 2013
var Fabricante = 'WV'
var Tipo = 'passeio'
var Licenciado = true

console.log(Nome)
console.log(Modelo)
console.log(Placa)
console.log(Ano_fabricacao)
console.log(Ano_modelo)
console.log(Fabricante)
console.log(Tipo)
console.log(Licenciado)

console.log("--------------------------------------")
console.log("2 - Array")
console.log("2.1 - Array Numeros")

var Numerico = new Array(0, 1, 2.3, 3, 4.5, 5, 6, 7.9, 8, 9.3)

console.log(Numerico)
console.log('Primeiro= ',Numerico[0])
console.log('Ultimo=', Numerico[9])

console.log("2.1 - Array Alunos")

var Alunos = new Array('Luiz', 'Ana', 'Vitor', 'Carlos', 'João', 'Andre', 'Bruna', 'Victor', 'Any', 'Jose')
 
console.log(Alunos)
console.log('Primeiro = ', Alunos[0])
console.log('Ultimo=', Alunos[9])

var arrayCarro = [ 
    { chassi: 123, placa: 'MFMV-1867', ano: 2022 }
    ,{ chassi: 111, placa: 'MCY-2148', ano: 1994 }
    ,{ chassi: 333, placa: 'RTT-5494', ano: 2000 }
    ,{ chassi: 222, placa: 'MRU-1972', ano: 2010 }
    ,{ chassi: 444, placa: 'CFR-9430', ano: 2020 }
    ,{ chassi: 666, placa: 'ERC-2341', ano: 2020 }
    ,{ chassi: 555, placa: 'LTU-1151', ano: 2020 }
    ,{ chassi: 777, placa: 'RYU-2000', ano: 2022 }
    ,{ chassi: 888, placa: 'MVP-6006', ano: 2021 }
    ,{ chassi: 999, placa: 'LOL-8882', ano: 2019 }
    ]
for (let carro of arrayCarro) {
    console.log(carro)
}

console.log('Primeiro=', arrayCarro[0].placa)
console.log('Ultimo=', arrayCarro[9].placa)

