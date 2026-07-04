using Estudos_Encapsulamento;

namespace App{

    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            p.Descricao = "Produto teste";
          
            Console.WriteLine($"Hello World! {p.Descricao}");
        }
    }

}