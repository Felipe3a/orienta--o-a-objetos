using System;

namespace LocadoraVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia a classe PessoaFisica e calcula a taxa de empréstimo
            PessoaFisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000);

            // Instancia a classe PessoaJuridica e calcula a taxa de empréstimo
            PessoaJuridica pj = new PessoaJuridica();
            pj.taxaEmprestimo(1000);
        }
    }
}
