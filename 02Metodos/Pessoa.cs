using System;

 class Pessoa
{
    //metodo 01

    public void apresentar() 
    {

     Console.WriteLine("Olá!!!");

    }

    //Metodo 02
    public void apresentar( string nome)
    {
    Console.WriteLine($"Olá  {nome}");
    }

    //Metodo 03
    public void apresentar( string nome, int idade) 
    {

      Console.WriteLine($"Olá  {nome} voçê tem {idade} amos");

    }
}
 //Metodo é nada a mais do que uma funcionalidade do objeto