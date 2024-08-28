using System;


namespace _03ExerciciosEscolar;

class Program
{
    static void Main(string[] args)
    {
       Aluno a = new Aluno();
       a.nome = "Felipe";
       a.nota1 = 0;
       a.nota2 = 8;
       a.mensagem();
    }
}
