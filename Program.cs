
using BancoSemRoubo;
Console.WriteLine("\nCRIANDO CONTA ");
Console.WriteLine("conta corrente: numero: 111, Titular: Maria");
Cliente cliente1 = new("Maria", 1);
Conta conta = new(111,cliente1);

conta.NumeroConta = 111;


Console.WriteLine("depositando R$1000");
conta.Depositar(1000);
Console.WriteLine("sacando 100");
conta.Sacar(100);

conta.ExibirSaldo();

Console.WriteLine("\nCRIANDO OUTRA CONTA ");

Cliente cliente2 = new("Savio", 2);
ContaPoupanca conta2 = new(222, cliente2);


Console.WriteLine("depositando R$2000");
conta2.Depositar(2000);
Console.WriteLine("sacando 200");
conta2.Sacar(200);

conta2.ExibirSaldo();

Console.WriteLine("\nCRIANDO OUTRA CONTA ");

Cliente cliente3 = new("Flavin", 3);
ContaInvestimento conta3 = new(333, cliente3);
Console.WriteLine("depositando R$3000");
conta3.Depositar(3000);
Console.WriteLine("sacando 300");
conta3.Sacar(300);
Console.WriteLine($"Titual da conta: {cliente3.Nome}");

conta3.ExibirSaldo();

Console.ReadKey();