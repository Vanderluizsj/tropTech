using System.Collections.Generic;
namespace salaDeAula
{
    public class Aluno
    {
       // número da matrícula e a nota da prova.
       public string Nome;
       public int Matricula;
       public double NotaProva;
        List<Aluno> AlunosCadastrados;

        public Aluno(string nome, int matricula, double nota){
            this.Nome = nome;
            this.Matricula = matricula;
            this.NotaProva = nota;
        }
        public Aluno(){

        }

        public void Cadastrar(Aluno aluno){
            //Adiciona um aluno a lista sempre que é chamada
            this.AlunosCadastrados.Add(aluno);

            
        }


    }
}