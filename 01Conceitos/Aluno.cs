using System;

class Aluno
{
     //atributo
private double nota1, nota2;

//Média 
private double media()
{
    return (nota1+nota2)/2;
}
  //menssagen
  public void mensagem()
  {
    Console.WriteLine("Infome a 1° nota");
    nota1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Innforme a 2° nota");
    nota2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("A média e " + media);
                Console.WriteLine($"A média é {media}");

  }
}