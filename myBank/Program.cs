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

            contaDoMarco.Sacar(50);
            Console.WriteLine("O saldo da conta do Marco é:R$"+ contaDoMarco.get(return saldo;));

        }
    }
}
