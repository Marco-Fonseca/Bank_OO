using System;


namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente contaDoMarco = new ContaCorrente("Marco",1234,789,100.50);

            ContaCorrente contaDoJoao = new ContaCorrente("João",1234,790,120);

            
            Console.WriteLine("O titular da conta é:" + contaDoMarco.titular);
            Console.WriteLine("O titular da conta é:" + contaDoJoao.titular);
            
        }
    }
}
