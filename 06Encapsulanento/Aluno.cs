using System;



namespace _06Encapsulanento;

class Aluno
{
    //Atributos
    private double nota1, nota2;

    //Média
    private double media()
    {
        return (nota1 + nota2) /2;
    }
    
    //mensagem

    public void mensagem()
    {
        



            Console.WriteLine("Informe a primeira nota:");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota:");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A sua nota é "+ media());



    }
}
