using Estudos_Encapsulamento;

namespace App{

    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.Write("Digite seu nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite a descrição do produto");
            p.Descricao = Console.ReadLine();


        }
    }

}