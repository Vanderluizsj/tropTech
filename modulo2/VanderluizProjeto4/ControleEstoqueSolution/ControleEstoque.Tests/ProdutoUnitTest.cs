using System;
using ControleEstoque.Excecoes;
using NUnit.Framework;

namespace ControleEstoque.Tests
{
    public class ProdutoUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /* 1 - Quando acrescentar 5 itens no produto e quantidade inicial do produto for 20, então deve atualizar quantidade do produto para 25.*/
        [Test]
        public void QuantidaIgual25_SeEstoqueFor20eAcrescentar5()
        {
            //arrange
            var produto = new Produto("Carro", "seminovos", 20);
            //action
            var produtos = produto.AcrescentarQuantidade(5);
            //assert
            Assert.AreEqual(25, produtos);
        }
        /* 2 - Quando acrescentar 0 itens no produto e quantidade inicial do produto for 20 então não deve atualizar a quantidade de itens do produto.*/
        [Test]
        
        public void QuantidadeNaoMudaSeAcrescentar0()
        {
            //arrange
            var produto = new Produto("Carro", "seminovos", 20);
            //action e assert
            QuantidadeMenorOuIgualAZeroException excecao = Assert.Throws<QuantidadeMenorOuIgualAZeroException>(()=>produto.AcrescentarQuantidade(0));           
           
        }
        /* 3 - Quando acrescentar -5 itens no produto e quantidade inicial do produto for 20 então não deve atualizar a quantidade de itens do produto*/
        [Test]
        
        public void QuantidadeNaoMudaSeAcrescentarNumeroNegativo()
        {
            //arrange
            var produto = new Produto("Carro", "seminovos", 20);
            //action e assert
            QuantidadeMenorOuIgualAZeroException excecao = Assert.Throws<QuantidadeMenorOuIgualAZeroException>(()=>produto.AcrescentarQuantidade(-5));           
           
        }

        [Test]
        public void QuantidaIgual15_SeEstoqueFor20eDeduzir5()
        {
            //arrange
            var produto = new Produto("Carro", "seminovos", 20);
            //action
            var produtos = produto.DeduzirQuantidade(5);
            //assert
            Assert.AreEqual(15, produtos);
        }
        /*5 - Quando deduzir 0 itens no produto e quantidade inicial do produto for 20 então não deve atualizar a quantidade de itens do produto*/
        [Test]
        
        public void QuantidadeNaoMudaSeDeduzir0()
        {
            //arrange
            var produto = new Produto("Carro", "seminovos", 20);
            //action e assert
            QuantidadeMenorOuIgualAZeroException excecao = Assert.Throws<QuantidadeMenorOuIgualAZeroException>(()=>produto.DeduzirQuantidade(0));           
           
        }

        /*6 - Quando deduzir -5 itens no produto e quantidade inicial do produto for 20 então não deve atualizar a quantidade de itens do produto*/
        public void QuantidadeNaoMudaSeDeduzirNumeroNegativo()
        {
            //arrange
            var produto = new Produto("Carro", "seminovos", 20);
            //action e assert
            QuantidadeMenorOuIgualAZeroException excecao = Assert.Throws<QuantidadeMenorOuIgualAZeroException>(()=>produto.DeduzirQuantidade(-5));           
           
        }

        /*7 - Quando deduzir 6 itens no produto e quantidade inicial do produto for 5 então a quantidade atualizada deve ser 0*/
        [Test]
        public void QuantidaIgual0_SeEstoqueFor5eDeduzir6()
        {
            //arrange
            var produto = new Produto("Carro", "seminovos", 5);
            //action
            var produtos = produto.DeduzirQuantidade(6);
            //assert
            Assert.AreEqual(0, produtos);
        }





    }
}