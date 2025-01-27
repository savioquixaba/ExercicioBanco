using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSemRoubo
{
    internal class ContaPoupanca : Conta
    {

        private const double jurosMensais = 0.005;
        public ContaPoupanca(int numeroConta, Cliente cliente): base(numeroConta,cliente)
        { 
        }
        public override void Depositar(double valor)
        {
            base.Depositar(valor);
            AplicarJuros();
        }

        private void AplicarJuros()
        {
            double juros = Saldo * jurosMensais;
            Saldo = Saldo + juros;

            // Exibe no console o valor dos juros e o novo saldo
            Console.WriteLine($"Juros de 0,5% aplicados: {juros}. Novo saldo: {Saldo}");
        }
    }
}
