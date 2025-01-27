using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BancoSemRoubo
{
    internal class Conta
    {
        private int numeroConta;
        private double saldo;
        private Cliente cliente;

        public Conta(int numeroConta, Cliente cliente)
        {
            this.numeroConta = numeroConta;
            this.saldo = 0;
            this.cliente = cliente;
        }

        public int NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            protected set { saldo = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            private set { cliente = value; }
        }

        //metodos

        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo = saldo+valor;
            }
            else
                Console.WriteLine("Valor de Deposito invalido.");
        }
        public void Sacar(double valor)
        {
            if (valor > 0 && saldo >= valor)
                saldo = saldo - valor;
            else 
                Console.WriteLine("saldo insuficiente ou valor invalido");
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {saldo}");
        }


    }
}
