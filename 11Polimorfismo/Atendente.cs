using System;

namespace _11Polimorfismo;

class Atendente : Imposto
{
    // Sobrescreve o método valeAlimentacao para aplicar uma lógica específica para Atendente.
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto do atendente vale alimentação R$ {salario * 0.12}");
    }
}
