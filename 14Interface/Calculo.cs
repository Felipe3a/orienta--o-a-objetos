using System;

namespace _14Interface;

class Calculo : IPadrao
{
    public  void somar(int n1, int n2)

{  
     Console.WriteLine("A soma é "+ (n1 + n2));
}


public void subtrair(int n1, int n2)
{
    Console.WriteLine("A subtrção é  " + (n1 -n2));
}

}


