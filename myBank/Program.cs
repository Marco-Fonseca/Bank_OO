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

            bool retorno = contaDoMarco.Sacar(50);
            Console.WriteLine(retorno);
            Console.WriteLine("O saldo da conta do Marco é:R$"+ contaDoMarco.saldo);
           

            contaDoMarco.Depositar(150);
            Console.WriteLine("O saldo da conta do Marco é:R$"+ contaDoMarco.saldo);

            contaDoMarco.Trasnferir(200,contaDoJoao);
            Console.WriteLine("O saldo da conta do Marco é:R$"+ contaDoMarco.saldo);
            Console.WriteLine("O saldo da conta do João é:R$"+ contaDoJoao.saldo);
        }
    }
}
