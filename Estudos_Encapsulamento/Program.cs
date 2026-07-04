using Estudos_Encapsulamento;

namespace App{

    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            p.SetNome("Pedro");

            Console.WriteLine($"Hello World! {p.GetNome()}");
        }
    }

}