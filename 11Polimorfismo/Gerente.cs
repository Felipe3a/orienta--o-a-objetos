using System;

namespace _11Polimorfismo;

class Gerente : Imposto
{
    // Sobrescreve o método valeAlimentacao para aplicar uma lógica específica para Gerente.
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto do gerente vale alimentação R$ {salario * 0.15}");
    }
}
