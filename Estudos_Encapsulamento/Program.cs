using Estudos_Encapsulamento;

namespace App{

    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine($"Hello World! {p.GetNome()}");
        }
    }

}