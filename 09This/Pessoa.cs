using System;

namespace _09This;

class Pessoa
{
    // Atributo 'nome' da classe, com valor inicial "Jurema"
    private string nome = "Jurema";

    // Construtor da classe Pessoa que recebe um parâmetro 'nome'
    public Pessoa(string nome)
    {
        // Imprime o valor do parâmetro 'nome', que foi passado ao criar o objeto
        Console.WriteLine(nome); // Isso imprime "Felipe"

        // Imprime o valor do atributo 'nome' da classe, usando 'this' para se referir ao atributo da instância
        Console.WriteLine(this.nome); // Isso imprime "Jurema"
    }
}

