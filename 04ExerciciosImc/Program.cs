namespace _04ExerciciosImc;

class Program
{
    static void Main(string[] args)
    {
          Pessoa p = new Pessoa();
            
            Console.Write("Digite a sua altura: ");
            p.altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o seu peso: ");
            p.peso = Convert.ToDouble(Console.ReadLine());
       p.mensagen();
    }
}
