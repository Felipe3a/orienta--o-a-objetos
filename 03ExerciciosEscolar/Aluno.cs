using System;



class Aluno
{
//Atributos 
public string nome;

public double nota1, nota2;



// veja  Abaixo os Metodos = Ações:


//Média

public double media()
{
return( nota1 + nota2) /2;

}

// Situação

public string situacao( double media)
{

return media >= 7 ? "Aprovado" : "Reprovado";

}


//Mensagen

public void mensagem()
{

//Obter Média
double obterMedia = media();


//Obter Situação

string obterSituacao = situacao(obterMedia);

//Mensagem
//Console.WriteLine( $"Olá {nome}, voçê foi {obterSituacao}, sua média foi {obterMedia}" );
if(obterMedia <= 7){
   Console.WriteLine( $"Que pena, {nome} voçê foi {obterSituacao}, sua média foi {obterMedia}, mas não desista, tente outra vez" ); 
}
else{Console.WriteLine( $"Parabénz {nome}, voçê foi {obterSituacao}, sua média foi {obterMedia}" );}
}

}
