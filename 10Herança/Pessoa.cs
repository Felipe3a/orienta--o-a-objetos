

using System;

namespace _10Herança;

class Pessoa
{
    //Atribitos
    protected string nome;
    protected int idade;

    //Método: também podemos ter métodos protegidos

    protected void mensagemPessoa()
    {
        Console.WriteLine($"Nome:{nome}");
        Console.WriteLine($"Idade:{idade}");
    }
    }

