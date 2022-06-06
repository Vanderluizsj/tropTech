using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastrarCliente cliente1 = new Endereco("Luiz", 18, "Padre Agostinho", "Araucaria", 12, "Lages", "SC");
            cliente1.listagem();
        }
    }
}
