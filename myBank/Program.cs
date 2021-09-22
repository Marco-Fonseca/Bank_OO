using System;


namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente contaDoMarco = new ContaCorrente("Marco",1234,789,100.50);
            ContaCorrente contaDoJoao = new ContaCorrente("João",1234,790,120);
            ContaCorrente contaDaMaria = new ContaCorrente("Maria",1234,791,150);

            contaDoJoao.Trasnferir(120, contaDoMarco); 
            Console.WriteLine("O saldo da conta do João é:R$"+ contaDoJoao.Saldo);
            Console.WriteLine("O saldo da conta do Marco é:R$"+ contaDoMarco.Saldo);
            

        }
    }
}
