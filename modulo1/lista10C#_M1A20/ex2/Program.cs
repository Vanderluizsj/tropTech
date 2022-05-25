using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            
            
            string sucesso = "";
            int nProdutos;
            int controle = 0;
            while (controle<1)
            {
                Console.Write("Informe o numero de produtos: ");
                sucesso = Console.ReadLine();     
                controle = String.IsNullOrEmpty(sucesso)? 0 : 1;                    
            }
            nProdutos = int.Parse(sucesso);
            string[] nomeProduto = new string[nProdutos];
            int[] codigoProduto = new int[nProdutos];
            string[] valorFinal = new string[nProdutos];
           	
            Iniciar();

            void Iniciar()
            {
                CadastraProduto();
                RenderizarImprimir();
            }           

            void CadastraProduto(){
                for(int i =0; i < nProdutos; i++)
                {
                    
                    int codigoAual = 0;        
                    do
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.Write("Digite um nome de produto valido: ");
                        nomeProduto[i] = Console.ReadLine();
                        string nome = nomeProduto[i];                    
                        controle = String.IsNullOrEmpty(nome)? 0 : 1;
                    } while (controle<1);
                        
                    do
                    {
                        Console.Write("\nDigite um código de 1 a 10 para o produto: ");
                        string teste = Console.ReadLine();
                        if (String.IsNullOrEmpty(teste))
                        {
                            controle = 0;
                        }
                        else
                        {                                                 
                            controle = 1;                    
                            codigoProduto[i] = int.Parse(teste);
                            codigoAual = codigoProduto[i];
                        }    
                    } while (codigoAual<1 || codigoAual>10 || controle<1);                     
                                               
                    EncontrarvalorFinal(codigoAual, i);                              
                }
            }
            void EncontrarvalorFinal(int codigo, int i){
                switch (codigo)
                {
                    case 1:
                        valorFinal[i] = "Alimento não-perecivel";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        valorFinal[i] = "Alimento perecivel";
                        break;
                    case 5:
                    case 6:
                        valorFinal[i] = "Vestuário";
                        break;
                    case 7:
                        valorFinal[i] = "Higiene pessoal";
                        break;
                    case 8:
                    case 9:
                    case 10:
                        valorFinal[i] = "Utensílios domésticos";
                        break;                    
                    default:
                        Console.WriteLine("Código inválido! Tente novamente.");
                        break;
                }
            }
            void RenderizarImprimir()
            {
                Console.Clear();
                Console.WriteLine($"Nome Produto:\t\tClassificação:");
                Console.WriteLine($"-------------\t\t--------------");
                for(int i =0; i < nProdutos; i++){
                    Console.Write($"\n{nomeProduto[i]}\t\t\t{valorFinal[i]}");
                }              

            }

        }
    }
}
