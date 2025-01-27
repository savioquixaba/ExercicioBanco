using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSemRoubo
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(int numeroConta, Cliente cliente):base(numeroConta, cliente) {
            Console.WriteLine("Conta corrente Criada!");
        }
    }
}
