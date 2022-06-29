using NUnit.Framework;
using ControleEstoque.Excecoes;
namespace ControleEstoque.Tests
{
    public class EstoqueUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /*1 - Quando cadastrar produto no estoque e produto ainda não existir no estoque então deve concluir cadastro com sucesso*/
        [Test]
        public void CadastroDeProdutoOk()
        {
            //arrange
            var estoque = new Estoque();
            var produto = new Produto("carro", "novo");
            //action
            var produtoCadastrado = estoque.CadastrarProdutoNoEstoque("carro", "novo");
            //assert
            Assert.AreEqual(produto, produtoCadastrado);       
           
        }

        /* 2 - Quando cadastrar produto no estoque e produto já existir no estoque então não deve concluir cadastro*/
        [Test]
        public void FalhaPoisProdutoJaFoiCadastrado()
        {
            //arrange
            var estoque = new Estoque();
            //action
            estoque.CadastrarProdutoNoEstoque("carro", "novo");
            //assert
            ProdutoJaCadastradoException excecao = Assert.Throws<ProdutoJaCadastradoException>(()=>estoque.CadastrarProdutoNoEstoque("carro", "novo"));       
           
        }
        /* 3 - Quando registrar a entrada de produtos no estoque e produto não existir no estoque então não deve concluir a ação*/
        [Test]
        public void FalhaPoisProdutoNaoExisteEntaoNaoPodeRegistrar()
        {
            //arrange
            var estoque = new Estoque();
            //action e assert
            ProdutoNaoEncontradoException excecao = Assert.Throws<ProdutoNaoEncontradoException>(()=>estoque.RegistrarEntradaDeProduto(1, 1));       
           
        }
        /* 4 - Quando registrar a entrada de 5 itens de produtos no estoque e produto existir no estoque então deve concluir a ação*/
        [Test]
        public void RegistroBemSucedidoDeItemNoEstoque()
        {
            //arrange
            var estoque = new Estoque();
            var produto = new Produto("carro", "novo");
            produto.DefineId();
            //action
            var produtoCadastrado = estoque.CadastrarProdutoNoEstoque("carro", "novo");
            estoque.RegistrarEntradaDeProduto(1, 5);
            //assert
            Assert.IsTrue(estoque.HaProdutosEmEstoque());                    
           
        }
        /* 5 - Quando registrar a saída de 5 itens de produtos no estoque e produto não existir no estoque então não deve concluir a ação*/
        [Test]
        public void FalhaPoisProdutoNaoExisteEntaoNaoPodeRegistrarSaida()
        {
            //arrange
            var estoque = new Estoque();
            //action e assert
            ProdutoNaoEncontradoException excecao = Assert.Throws<ProdutoNaoEncontradoException>(()=>estoque.RegistrarSaidaDeProduto(1, 1));       
           
        }

        /* 6 - Quando registrar a saída de 5 itens de produtos no estoque e produto existir no estoque com quantidade maior ou igual a 5 então deve concluir a ação*/
        [Test]
        public void RegistroDeSaidaBemSucedidoDeItemDoEstoque()
        {
            //arrange
            var estoque = new Estoque();
            var produto = new Produto("carro", "novo");
            produto.DefineId();
            //action
            var produtoCadastrado = estoque.CadastrarProdutoNoEstoque("carro", "novo");
            estoque.RegistrarEntradaDeProduto(1, 7);
            estoque.RegistrarSaidaDeProduto(1, 5);
            //assert
            Assert.IsTrue(estoque.HaProdutosEmEstoque());                    
           
        }
        /* 7 - Quando verificar se há itens no estoque e quantidade de itens for igual a zero então deve informar que não há*/

         [Test]
        public void VerificacaoDeProdutosNoEstoqueQuandoNaoTemProdutosNoEstoque()
        {
            //arrange
            var estoque = new Estoque();
            Assert.IsFalse(estoque.HaProdutosEmEstoque());                    
           
        }


        /* 8 - Quando verificar se há itens no estoque e quantidade de itens for maior que zero então deve informar que há*/
        
        [Test]
        public void VerificacaoDeItemNoEstoqueQuandoQuantidadeMaiorQue0()
        {
            //arrange
            var estoque = new Estoque();
            var produto = new Produto("carro", "novo");
            produto.DefineId();
            //action
            var produtoCadastrado = estoque.CadastrarProdutoNoEstoque("carro", "novo");
            estoque.RegistrarEntradaDeProduto(1, 7);
            
            //assert
            Assert.IsTrue(estoque.HaProdutosEmEstoque());                    
           
        }
    }
}