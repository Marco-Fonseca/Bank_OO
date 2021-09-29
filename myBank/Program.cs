using System;


namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario funcionarioPedro = new Funcionario("Pedro","123.123.123-12","Vendedor",1000);
            Funcionario funcionarioJorge = new Funcionario("Jorge","321.321.321-21","Vendedor",1000);
            
            ContaCorrente contaDoMarco = new ContaCorrente("Marco",1234,100,funcionarioPedro);
            contaDoMarco.Conta = 789;

            ContaCorrente contaDoGustavo = new ContaCorrente("Gustavo",1234,120,funcionarioJorge);
            contaDoGustavo.Conta = 790;

            ContaCorrente contaDaMarcia = new ContaCorrente("Márcia",1234,150,funcionarioPedro);
            contaDaMarcia.Conta = 791;

            Console.WriteLine("A Conta corrente 1 é a do:"+ contaDoMarco.Titular);
            Console.WriteLine("A Conta corrente 2 é a do:"+ contaDoGustavo.Titular);
            Console.WriteLine("A Conta corrente 3 é a da:"+ contaDaMarcia.Titular);
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Funcionário 1 é o:"+ funcionarioPedro.Nome);
            Console.WriteLine("Funcionário 2 é o:"+ funcionarioJorge.Nome);
            Console.WriteLine("----------------------------------------------------");
           
           contaDoMarco.Sacar(50);
           Console.WriteLine("O saldo da conta do Marco é R$"+ contaDoMarco.Saldo);
           Console.WriteLine("----------------------------------------------------");

           contaDoGustavo.Depositar(300);
           Console.WriteLine("O saldo da conta do Gustavo é R$"+ contaDoGustavo.Saldo);
           Console.WriteLine("----------------------------------------------------");

           contaDoGustavo.Trasnferir(200,contaDaMarcia);
           Console.WriteLine("O saldo da conta do Gustavo é R$"+ contaDoGustavo.Saldo);
           Console.WriteLine("O saldo da conta da Márcia é R$"+ contaDaMarcia.Saldo);
           Console.WriteLine("----------------------------------------------------");

           Console.WriteLine("O número total de contas é:"+ ContaCorrente.TotalContaCriadas);

            /*Console.WriteLine("O saldo da conta do João é:R$"+ contaDoJoao.Saldo);
            Console.WriteLine("O saldo da conta do Marco é:R$"+ contaDoMarco.Saldo);
            Console.WriteLine("O número total de contas é:"+ ContaCorrente.TotalContaCriadas);
            Console.WriteLine("O total de comissão do funcionário é R$"+ ContaCorrente.TotalDeComissao);
            Console.WriteLine("O total de comissão do funcionário é R$"+ ContaCorrente.TotalDeComissao);
            Console.WriteLine("A comissão do funcionário Pedro é R$"+ funcionarioPedro.Comissao);
            Console.WriteLine("A comissão do funcionário Jorge é R$"+ funcionarioJorge.Comissao);*/
        }
    }
}
