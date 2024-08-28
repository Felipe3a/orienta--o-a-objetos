using System;

namespace _11Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        // Instanciar Estagiário
        Imposto objE = new Estagiario(); // Cria uma instância da classe Estagiario e a referencia como do tipo Imposto.
        objE.valeAlimentacao(1000); // Chama o método valeAlimentacao da classe Estagiario, que herda da classe Imposto.
        objE.valeTransporte(1000); // Chama o método valeTransporte da classe Imposto.
        Console.WriteLine("----------------------------------------------");

        // Instanciar Gerente
        Imposto objG = new Gerente(); // Cria uma instância da classe Gerente e a referencia como do tipo Imposto.
        objG.valeAlimentacao(1000); // Chama o método valeAlimentacao da classe Gerente, que sobrescreve o método na classe Imposto.
        objG.valeTransporte(1000); // Chama o método valeTransporte da classe Imposto, pois não foi sobrescrito em Gerente.
        Console.WriteLine("----------------------------------------------");

        // Instanciar Atendente
        Imposto objA = new Atendente(); // Cria uma instância da classe Atendente e a referencia como do tipo Imposto.
        objA.valeAlimentacao(2000); // Chama o método valeAlimentacao da classe Atendente, que sobrescreve o método na classe Imposto.
        objA.valeTransporte(2000); // Chama o método valeTransporte da classe Imposto.
    }
}
