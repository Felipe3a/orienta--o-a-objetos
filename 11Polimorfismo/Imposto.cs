using System;

namespace _11Polimorfismo;

class Imposto
{
    // Método que pode ser sobrescrito pelas classes derivadas.
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto padrão do vale alimentação R$ {salario * 0.1}");
    }
    
    // Método que não pode ser sobrescrito, todas as classes derivadas usarão esta implementação.
    public void valeTransporte(double salario)
    {
        Console.WriteLine($"Desconto padrão do vale transporte R$ {salario * 0.06}");
    }
}
