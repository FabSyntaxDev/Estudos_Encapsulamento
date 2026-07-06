using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_Encapsulamento
{
    internal class Produto
    {
        private string _nome = "jose";
        private string _descricao = "objeto bom";
        private double _preco;


        public string GetNome()
        {
            return _nome;
        }
        

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public double preco
        {
            get { return _preco; }
        }




    }
}
