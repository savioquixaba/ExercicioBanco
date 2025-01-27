using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSemRoubo
{
    internal class Cliente
    {
        private string nome;
        private int numeroCliente;

        public Cliente(string nome, int numeroCliente)
        {
            this.Nome = nome;
            this.NumeroCliente = numeroCliente;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumeroCliente
        {
            get { return numeroCliente; }
            set { numeroCliente = value; }
        }
    }
}
