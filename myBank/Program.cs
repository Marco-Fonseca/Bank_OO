using System;


namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente contaDoMarco = new ContaCorrente("Marco",1234,100);
            contaDoMarco.Conta = 789;

            ContaCorrente contaDoJoao = new ContaCorrente("João",1234,120);
            contaDoJoao.Conta = 790;

            ContaCorrente contaDaMaria = new ContaCorrente("Maria",1234,150);
            contaDaMaria.Conta = 791;

            /*contaDoJoao.Trasnferir(120, contaDoMarco); 
            Console.WriteLine("O saldo da conta do João é:R$"+ contaDoJoao.Saldo);
            Console.WriteLine("O saldo da conta do Marco é:R$"+ contaDoMarco.Saldo);
            Console.WriteLine("A conta do Marco é:" + contaDoMarco.Conta);*/

            Console.WriteLine("O número total de contas é:"+ ContaCorrente.TotalContaCriadas);
            

        }
    }
}
