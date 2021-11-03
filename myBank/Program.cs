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
                Salario = 2000 ,
                NumeroDeAgencias = 4
            };

            Vendedor vendedorPedro = new Vendedor()
            {
                Nome = "Pedro",
                CPF = "123.123.123-12",
                Salario = 1000 ,
                NumeroClientesAtendidos = 3
            };
            Vendedor vendedorJorge = new Vendedor()
            {
                Nome = "Jorge",
                CPF = "321.321.321-21",
                Salario = 1000 ,
                NumeroClientesAtendidos = 5
            };
            
                gerenteHenrique.Bonificacao = gerenteHenrique.Salario;
        
             Console.WriteLine("A Remuneração total do gerente Henrique é de R$" + gerenteHenrique.RemuneracaoTotal(gerenteHenrique.Salario,gerenteHenrique.Bonificacao));

        }
    }
}
