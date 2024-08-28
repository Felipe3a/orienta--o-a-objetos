using System;

namespace LocadoraVeiculos
{
    class PessoaFisica : Padrao
    {
        // Implementação do método obrigatório taxaEmprestimo.
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de empréstimo para Pessoa Física: R$ {valor * 0.1}");
        }
    }
}
