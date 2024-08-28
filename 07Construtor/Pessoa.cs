using System; 

class Pessoa
{
   //Construtor

   public Pessoa()
{   
    Console.WriteLine("Construtor executado");
}


public Pessoa(string nome,double idade)
{
    Console.WriteLine($"Olá {nome} voçê tem {idade} anos de idade!");
}



}
