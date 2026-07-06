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


        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public double preco
        {
            get { return _preco; }
            set
            {
                if (value >= 10) { }
                _preco = value;
            }




    }
}
}
