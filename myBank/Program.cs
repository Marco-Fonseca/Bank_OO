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
                Salario = 2000
            };

            Vendedor vendedorPedro = new Vendedor()
            {
                Nome = "Pedro",
                CPF = "123.123.123-12",
                Salario = 1000
            };
            Vendedor vendedorJorge = new Vendedor()
            {
                Nome = "Jorge",
                CPF = "321.321.321-21",
                Salario = 1000
            };

            vendedorPedro.Bonificacao = vendedorPedro.Salario;

             Console.WriteLine("O salario do gerente Henrique é R$" + gerenteHenrique.Salario);
             Console.WriteLine("O Bonificação do Pedro é:"+ vendedorPedro.Bonificacao);

           /* ContaCorrente contaDoMarco = new ContaCorrente("Marco",1234,100,funcionarioPedro);
            contaDoMarco.Conta = 789;

            ContaCorrente contaDoGustavo = new ContaCorrente("Gustavo",1234,120,funcionarioJorge);
            contaDoGustavo.Conta = 790;

            ContaCorrente contaDaMarcia = new ContaCorrente("Márcia",1234,150,funcionarioPedro);
            contaDaMarcia.Conta = 791;

            
            Console.WriteLine("O Bonificação do Pedro é:"+ funcionarioPedro.Bonificacao);
            Console.WriteLine("O Salario do Pedro é:"+ funcionarioPedro.Salario);


            Console.WriteLine("A Conta corrente 1 é a do:"+ contaDoMarco.Titular);
            Console.WriteLine("A Conta corrente 2 é a do:"+ contaDoGustavo.Titular);
            Console.WriteLine("A Conta corrente 3 é a da:"+ contaDaMarcia.Titular);
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Funcionário 1 é o:"+ funcionarioPedro.Nome);
            Console.WriteLine("Funcionário 2 é o:"+ funcionarioJorge.Nome);
            Console.WriteLine("----------------------------------------------------");
           
           Console.WriteLine("O saldo da conta do Marco é R$"+ contaDoMarco.Saldo);
           Console.WriteLine("Sacando R$50,00");
           contaDoMarco.Sacar(50);
           Console.WriteLine("O saldo da conta do Marco é R$"+ contaDoMarco.Saldo);
           Console.WriteLine("----------------------------------------------------");

           Console.WriteLine("O saldo da conta do Gustavo é R$"+ contaDoGustavo.Saldo);
           Console.WriteLine("Depositando R$300,00");
           contaDoGustavo.Depositar(300);
           Console.WriteLine("O saldo da conta do Gustavo é R$"+ contaDoGustavo.Saldo);
           Console.WriteLine("----------------------------------------------------");


           Console.WriteLine("O saldo da conta do Gustavo é R$"+ contaDoGustavo.Saldo);
           Console.WriteLine("O saldo da conta da Márcia é R$"+ contaDaMarcia.Saldo);
           Console.WriteLine("Transferindo R$200,00 do Gustavo para a Márcia");
           contaDoGustavo.Trasnferir(200,contaDaMarcia);
           Console.WriteLine("O saldo da conta do Gustavo é R$"+ contaDoGustavo.Saldo);
           Console.WriteLine("O saldo da conta da Márcia é R$"+ contaDaMarcia.Saldo);
           Console.WriteLine("----------------------------------------------------");

           Console.WriteLine("O número total de contas é:"+ ContaCorrente.TotalContaCriadas);*/
        }
    }
}
