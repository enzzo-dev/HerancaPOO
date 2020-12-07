using System;
using HerancaPOO.classes;

namespace HerancaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //SubClasse instanciada
            PessoaFisica pf = new PessoaFisica();

            System.Console.WriteLine("Insira seu nome: ");
            pf.nome = Console.ReadLine();

            Console.WriteLine(pf.DarBoasVindas(pf.nome));

            System.Console.WriteLine("Insira seu cpf: ");
            pf.cpf = Console.ReadLine();
            
            System.Console.WriteLine(pf.ValidarCPF(pf.cpf));

        }
    }
}
