using System;


namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

             Gerente gerenteHenrique = new Gerente (){

                Nome = "Henrique",
                CPF = "987.987.987-98",
                Salario = 3000 ,
                NumeroDeAgencias = 4
            };
             gerenteHenrique.Bonificacao = gerenteHenrique.Salario;

            Vendedor vendedorPedro = new Vendedor()
            {
                Nome = "Pedro",
                CPF = "123.123.123-12",
                Salario = 1000 ,
                NumeroClientesAtendidos = 4
            };
            vendedorPedro.Bonificacao = vendedorPedro.Salario;

            Vendedor vendedorJorge = new Vendedor()
            {
                Nome = "Jorge",
                CPF = "321.321.321-21",
                Salario = 1000 ,
                NumeroClientesAtendidos = 1
            };
            vendedorJorge.Bonificacao = vendedorJorge.Salario;

            Vendedor vendedorGustavo = new Vendedor()
            {
                Nome = "Gustavo",
                CPF = "456.546.567-98" ,
                Salario = 1000 ,
                NumeroClientesAtendidos = 2
            };
            vendedorGustavo.Bonificacao = vendedorGustavo.Salario;

            ContaCorrente contaMarco = new ContaCorrente ("Marco Antônio Pereira Alves Fonseca","789.987.654-23",345,2500,vendedorPedro);
            contaMarco.Conta = 2026;

            ContaCorrente contaLeonardo = new ContaCorrente ("Leonardo","653.460.123-67",345,1500,vendedorJorge);
            contaLeonardo.Conta = 5422;

            ContaCorrente contaSofia = new ContaCorrente ("Sofia","531.242.454-11",247,500,vendedorGustavo);
            contaSofia.Conta = 3549;
           
            
            Console.WriteLine("----- Contas Correntes -----");
            Console.WriteLine("Conta 1: \nNome: " + contaMarco.Titular + ";" + "\nCPF: " + contaMarco.CPF + ";" + "\nAgência: " + contaMarco.Agencia + ";" + "\nConta: " + contaMarco.Conta + ";" + "\nSaldo: R$" + contaMarco.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Conta 2: \nNome: " + contaLeonardo.Titular + ";" + "\nCPF: " + contaLeonardo.CPF + ";" + "\nAgência: " + contaLeonardo.Agencia + ";" + "\nConta: " + contaLeonardo.Conta + ";" + "\nSaldo: R$" + contaLeonardo.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Conta 3: \nNome: " + contaSofia.Titular + ";" + "\nCPF: " + contaSofia.CPF + ";" + "\nAgência: " + contaSofia.Agencia + ";" + "\nConta: " + contaSofia.Conta + ";" + "\nSaldo: R$" + contaSofia.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----- Funcinários -----");
            Console.WriteLine("Vendedor 1: \nNome: " + vendedorPedro.Nome + ";" + "\nCPF: " + vendedorPedro.CPF + ";" + "\nSalário: R$" + vendedorPedro.Salario + ";" + "\nBonificação Anual R$: " + vendedorPedro.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + vendedorPedro.RemuneracaoTotal(vendedorPedro.Salario,vendedorPedro.Bonificacao) + ";" + "\nDias de Férias: " + vendedorPedro.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Vendedor 2: \nNome: " + vendedorJorge.Nome + ";" + "\nCPF: " + vendedorJorge.CPF + ";" + "\nSalário: R$" + vendedorJorge.Salario + ";" + "\nBonificação Anual R$: " + vendedorJorge.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + vendedorJorge.RemuneracaoTotal(vendedorJorge.Salario,vendedorJorge.Bonificacao) + ";" + "\nDias de Férias: " + vendedorJorge.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Vendedor 3: \nNome: " + vendedorGustavo.Nome + ";" + "\nCPF: " + vendedorGustavo.CPF + ";" + "\nSalário: R$" + vendedorGustavo.Salario + ";" + "\nBonificação Anual R$: " + vendedorGustavo.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + vendedorGustavo.RemuneracaoTotal(vendedorGustavo.Salario,vendedorGustavo.Bonificacao) + ";" + "\nDias de Férias: " + vendedorGustavo.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Gerente : \nNome: " + gerenteHenrique.Nome + ";" + "\nCPF: " + gerenteHenrique.CPF + ";" + "\nSalário: R$" + gerenteHenrique.Salario + ";" + "\nBonificação Anual R$: " + gerenteHenrique.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + gerenteHenrique.RemuneracaoTotal(gerenteHenrique.Salario,gerenteHenrique.Bonificacao) + ";" + "\nDias de Férias: " + gerenteHenrique.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Total de contas criadas:" + ContaCorrente.TotalContaCriadas + ".");
        }}}
