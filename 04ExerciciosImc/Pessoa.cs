using System;


public class Pessoa
{
   public double peso;
  public  double altura ;




    public double imc()
    {
return peso/(altura * altura);


    }
    public void mensagen()
    {

    double ObterImc = imc();
     ObterImc = Math.Round(ObterImc, 2);// arredonda valores
    
if(ObterImc < 18.5 )
{
Console.WriteLine($"Você esta abaixo do peso, seu imc é, {ObterImc}");

}

 else if(ObterImc > 18.5 && ObterImc< 25){
Console.WriteLine($"Peso normal, seu imc é, {ObterImc}");

}

else if(ObterImc > 25 && ObterImc < 30){
Console.WriteLine($"Acima do peso, seu imc é, {ObterImc} ");

}


else if(ObterImc > 30 && ObterImc < 35){
Console.WriteLine($"Obesidade I, seu imc é, {ObterImc} ");

}

else if(ObterImc > 35 && ObterImc < 40){
Console.WriteLine($"Obesidade II, seu imc é, {ObterImc} ");

}

else if(ObterImc >= 40){
Console.WriteLine($"Obesidade III, seu imc é, {ObterImc} ");
 }
}
}