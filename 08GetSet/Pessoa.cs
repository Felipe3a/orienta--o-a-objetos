
using System;

namespace _08GetSet
{
    

class Pessoa
{
    //Atributo
    private string nome;
    

    //Get Set , todo método get set é publico

    public string Nome 
    {

       get { return nome; }  //recebe a informação

        set { nome = value; } //envia a informação
    }
}
}