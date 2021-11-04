using System;

namespace CodigoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeProduto = "";
            int qtde = 0;
            double vlrUnitario = 0;

            double tb = 0, td = 0, vl = 0;

            Console.Write("Nome do Produto..: ");
            nomeProduto = Console.ReadLine();

            Console.Write("Quantidade.......: ");
            qtde = int.Parse(Console.ReadLine());

            Console.Write("Valor do item R$.: ");
            vlrUnitario = double.Parse(Console.ReadLine());

            tb = qtde * vlrUnitario;
            td = tb * 0.10;
            vl = tb - td;

            Console.WriteLine("Total Bruto...: R$ " + tb);
            Console.WriteLine("Total de Desc.: R$ " + td);
            Console.WriteLine("Valor Líquido.: R$ " + vl);

            Console.WriteLine("Fim do Programa!");
        }

    }

}
