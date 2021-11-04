using System;

namespace CodigoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //boas práticas de programação
            string marca = "";
            string modelo = "";
            double custo = 0;
            double imposto = 0;
            double vendedor = 0;
            double vlrTotal = 0;


            Console.Write("Marca...: ");
            marca = Console.ReadLine();

            Console.Write("Modelo..: ");
            modelo = Console.ReadLine();

            Console.Write("Valor do Custo (R$)..: ");
            custo = double.Parse(Console.ReadLine());

            imposto = custo * 0.45;
            vendedor = custo * 0.28;
            vlrTotal = custo + imposto + vendedor;

            Console.WriteLine("Marca.........: " + marca);
            Console.WriteLine("Modelo........: " + modelo);
            Console.WriteLine("Vlr Custo.....: " + custo);
            Console.WriteLine("Vlr Imposto...: " + imposto);
            Console.WriteLine("Comissão Ven..: " + vendedor);

            //valor Total - Final do veículo
            Console.WriteLine("Valor total...: " + vlrTotal);

            Console.WriteLine("Fim do Programa!");


        }

    }

}
