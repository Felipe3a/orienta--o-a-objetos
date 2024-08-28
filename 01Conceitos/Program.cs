using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
           //Instânciar - construtor = criar um objeto
 
            Pessoa obj = new Pessoa();
            obj.nome =" fulano";
            obj.idade = 30;
            obj.Mensagem();
        }
    }
}
