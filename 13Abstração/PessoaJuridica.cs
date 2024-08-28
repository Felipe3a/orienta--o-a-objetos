using System;

namespace LocadoraVeiculos
{
    class PessoaJuridica : Padrao
    {
        // Implementação do método obrigatório taxaEmprestimo.
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de empréstimo para Pessoa Jurídica: R$ {valor * 0.2}");
        }
    }
}
