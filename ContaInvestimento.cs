using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSemRoubo
{
    internal class ContaInvestimento : Conta
    {
        private const double JurosMensais = 0.009;
        private const double ImpostoCobrado = 0.001;

        public ContaInvestimento(int numeroConta, Cliente cliente) : base(numeroConta, cliente)
        {
        
        }
        
        public override void Depositar(double valor)
        {
            base.Depositar(valor);
            AplicarJuros();
        }
        public override void Sacar(double valor)
        {
            AplicarImposto();
            base.Sacar(valor);
            
        }

        public void AplicarJuros()
        {
            double Juros = Saldo * JurosMensais;
            Saldo = Saldo + Juros;
            
            Console.WriteLine($"Juros de 0,5% aplicados: {Juros}. Novo saldo: R${Saldo}");
        }

        public void AplicarImposto()
        {
            double Imposto = Saldo * ImpostoCobrado;
            Saldo = Saldo - Imposto;
            Console.WriteLine($"Imposto em R$: {Imposto}. Novo saldo: R${Saldo}");
        }

    }
}
