using Estudos_Encapsulamento;

namespace App{

    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Digite seu nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine(p.Nome);

        }
    }

}