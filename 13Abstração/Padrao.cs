using System;

namespace LocadoraVeiculos
{
    abstract class Padrao
    {
        // Método abstrato obrigatório que deve ser implementado nas classes filhas.
        public abstract void taxaEmprestimo(double valor);

        // Método opcional que já está implementado e calcula ganhos de poupança.
        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine($"Ganhos obtidos pela poupança: R$ {valor * taxa}");
        }
    }
}
